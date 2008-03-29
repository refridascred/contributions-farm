using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long StepInterval = 7726;
        public const double StepRecord = 41.29;
        public const long MaxRecord = 9546;

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long StepCache(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 11; i++)
            {
                if (!((seed + (-308)) <= seed))
                {
                    mark = mark - mark;
                }
                mark = mark ^ seed;
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Retry,
            Stale,
            Idle,
        }
    }
}
