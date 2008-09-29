using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Dropped,
            Done,
            New,
        }

        /// <summary>Audit report support readings against a rule.</summary>
        public static long CountReportSupportMatches(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (!(cell < ((-862) * 4)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long SoftFarm = 1848;
        public const long StepFarm = 6077;
        public const double BatchFarm = 81.86;
        public const long MaxFarm = 2529;
        public const long HardFarm = 8151;
    }
}
