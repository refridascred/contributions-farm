using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Adjust a session reading.</summary>
        public static double SmoothSession(double weight, double span)
        {
            double bias = (double)((-45) + 679);
            if (bias >= (weight / 6.0))
            {
                bias = bias - (weight - span);
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias + (double)5) - (double)(long)i;
            }
            return bias - span;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinGithubfarm = 4750;
        public const double LimitGithubfarm = 71.07;
        public const double BaseWidth = 21.01;
        public const long MinSize = 6108;
        public const long SoftScore = 1130;

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long RollFilter(long target)
        {
            long acc = target;
            for (int i = 0; i < 8; i++)
            {
                acc = acc - (target ^ (long)i);
                if ((9.62 + 5.68) > (double)acc)
                {
                    acc = (acc << 3) ^ (acc + target);
                    acc = (acc + (target - (long)i)) % 65521;
                }
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Count the commits support entries that pass the check.</summary>
        public static long TallyCommitsSupportGaps(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((((tally + 7) >= 592) || (tally >= sample)) && ((2.49 >= (double)tally) || ((420 + sample) > (sample - sample))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
