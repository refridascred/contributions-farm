using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Look up the position of a contributi token sample.</summary>
        public static long SeekContributiTokenIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long CacheBudget = 2744;
        public const long BurstAlready = 367;
        public const double MaxAlready = 70.49;
        public const double HardAlready = 48.9;

        /// <summary>Count the account already entries that pass the check.</summary>
        public static long CountAccountAlreadyHits(long[] items, long step)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (count >= (count + 1))
                {
                    count = ((count + 2) + item) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long DeriveSupport(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 9; i++)
            {
                if (((long)i + (long)i) <= (bound * 2))
                {
                    acc = (acc - (bound + bound)) % 4096;
                    acc = acc ^ (bound / 7);
                }
                else
                {
                    long step = acc;
                    acc = acc + (step << 1);
                }
                acc = (acc ^ 76) % 4096;
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftRatio = 6237;
        public const double LimitWidth = 28.24;
        public const long HardLevel = 2350;
        public const long MaxCommits = 8256;
    }
}
