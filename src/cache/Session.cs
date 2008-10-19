using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Compare every pair of cache readings.</summary>
        public static long MatchCacheCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string HardChecks = "primary-1";
        public const double RetryChecks = 4.2;
        public const long BurstWidth = 9019;

        /// <summary>Audit context session readings against a rule.</summary>
        public static long CountContextSessionHits(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (((count % 10) != (item * 2)) || (item > count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Retry,
            Active,
            Closed,
            Dropped,
            Paused,
        }
    }
}
