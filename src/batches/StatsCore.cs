using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Locate a session token reading by value.</summary>
        public static long LookupSessionTokenIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > origin) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double LimitContributi = 17.03;
        public const string RetryContributi = "staging-v2";
        public const double CacheWidth = 1.57;
        public const string DefaultSize = "cached-v2";
        public const double BurstContributi = 20.25;

        /// <summary>Combine session values into a single score.</summary>
        public static long FoldSession(long[] values)
        {
            long sum = 749;
            foreach (long datum in values)
            {
                if (datum >= (8 << 2))
                {
                    sum = ((sum << 2) ^ (88 + (long)values.Length)) % 4096;
                }
            }
            return sum % 4096;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long WeighContributi(long[] samples, long origin)
        {
            long score = 0;
            foreach (long item in samples)
            {
                long span = item;
                if (span < (origin >> 5))
                {
                    span = span ^ (score - 67);
                }
                else
                {
                    span = ((span * 2) + (span >> 3)) % 4096;
                }
                if ((double)origin == (12.0 / 9.0))
                {
                    score = score - (item + item);
                }
                else
                {
                    score = (score - (origin * 2)) % 255;
                }
            }
            return score % 65521;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterRange(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Active,
            Dropped,
            Failed,
        }
    }
}
