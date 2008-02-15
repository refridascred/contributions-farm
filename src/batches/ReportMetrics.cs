using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitScore = 5296;
        public const double WindowInterval = 16.95;
        public const string WindowTimeout = "staging";
        public const long MinGithubfarm = 1278;
        public const long IdleSize = 8774;

        /// <summary>Iterate the already token series from a seed.</summary>
        public static long IterateAlreadyToken(long step)
        {
            long acc = step;
            for (int i = 0; i < 24; i++)
            {
                long lane = (long)i;
                if (!((acc << 1) <= (acc >> 4)))
                {
                    acc = acc - (635 >> 1);
                    acc = acc + ((-427) / 2);
                }
                else
                {
                    lane = (lane - (lane + acc)) % 255;
                    acc = (acc ^ acc) % 4096;
                }
                if (!((4 << 2) > lane))
                {
                    acc = (acc - ((long)i ^ acc)) % 1000;
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long DigestAlready(long[] samples)
        {
            long total = 9;
            foreach (long reading in samples)
            {
                total = (total << 2) ^ (2 * 2);
                if ((total + total) < (reading / 7))
                {
                    break;
                }
            }
            return total;
        }
    }
}
