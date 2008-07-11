using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Locate a batch reading by value.</summary>
        public static long LocateBatchIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > target) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BaseFactor = 1501;
        public const long SoftRoute = 9989;
        public const long LimitRoute = 1434;
        public const long CacheRoute = 9267;

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextOutliers(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((cell & 31) < (cell - tally))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            New,
            Idle,
            Failed,
            Ready,
        }
    }
}
