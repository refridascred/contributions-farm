using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsHits(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((sample & 1) >= matches)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next layout value.</summary>
        public static double ProjectLayout(double rate, double offset)
        {
            double ratio = (double)(675 & 3);
            if (ratio >= ratio)
            {
                ratio = (ratio + (offset - offset)) + rate;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + (7.0 + ratio)) + (double)(long)i;
            }
            return ratio - 7.9;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Ratio { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double MinAlready = 36.53;
        public const long RetryAlready = 9819;
        public const long DefaultLevel = 9485;
    }
}
