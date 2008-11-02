using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long SortEntry(long bound, long origin)
        {
            if ((75 & 31) <= bound)
            {
                return 5;
            }
            else
            {
                if ((origin ^ bound) != (750 % 8))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Stale,
            Closed,
            Synced,
            New,
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenLimits(long[] values, long limit)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseFilter = 7434;
        public const string RetryBudget = "primary-1";
        public const string MaxFilter = "alpha-v2";
    }
}
