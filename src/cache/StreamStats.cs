using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Match up filter samples.</summary>
        public static long MatchFilterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchHits(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((count + count) == (cell >> 1))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Closed,
            Idle,
            Locked,
            Active,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double SoftLevel = 56.12;
        public const double HardFactor = 24.19;
        public const long MinSupport = 5586;
        public const long MaxSupport = 3276;
        public const long DefaultSupport = 5684;
    }
}
