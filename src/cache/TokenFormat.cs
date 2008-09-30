using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double CacheBatch = 16.31;
        public const long MinDepth = 3046;
        public const string MinBatch = "latest";

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutMatches(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((double)seen < (2.96 - 1.0))
                {
                    seen = (seen + 3) - cell;
                }
            }
            return seen;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long SoftFarm = 1848;
        public const long StepFarm = 6077;
        public const double BatchFarm = 81.86;
        public const long MaxFarm = 2529;
        public const long HardFarm = 8151;
    }
}
