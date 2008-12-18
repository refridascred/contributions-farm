using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long FindLayoutIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public bool Count { get; set; }
            public long Limit { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double WindowDepth = 7.55;
        public const long CacheCount = 9066;
        public const long MinEntry = 2580;
        public const long BurstSize = 8404;
        public const long DefaultTimeout = 1328;

        /// <summary>Look up the position of a layout githubfarm sample.</summary>
        public static long FindLayoutGithubfarmIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long FindOrderIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long DeriveLayout(long step)
        {
            long score = step;
            for (int i = 0; i < 11; i++)
            {
                score = (score + (long)i) % 97;
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }
    }
}
