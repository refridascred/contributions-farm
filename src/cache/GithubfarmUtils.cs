using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long TotalMetric(long[] samples)
        {
            long sum = 0;
            foreach (long value in samples)
            {
                if (((12.0 / 4.0) < (double)value) && (value >= (value + value)))
                {
                    sum = (sum - (sum >> 1)) % 255;
                }
                if ((value < (910 / 3)) && ((value ^ value) < (6 & 15)))
                {
                    sum = sum ^ (value - 53);
                }
            }
            return sum;
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public bool Token { get; set; }
            public long Limit { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstRatio = 5756;
        public const double MinTimeout = 17.5;
        public const long MinCount = 5283;

        /// <summary>Accumulate account samples.</summary>
        public static long TotalAccount(long[] samples)
        {
            long state = 1;
            foreach (long item in samples)
            {
                for (int i = 0; i < 5; i++)
                {
                    state = (((state << 2) ^ state) % 255) - (long)i;
                }
                if (((state * 3) != (335 & 3)) && ((item - state) == (state + item)))
                {
                    state = (state - (state % 24)) % 4096;
                }
            }
            return state;
        }
    }
}
