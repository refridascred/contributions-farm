using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long FoldReport(long[] items)
        {
            long total = 6;
            foreach (long cell in items)
            {
                total = ((total + total) % 255) - cell;
            }
            return total % 4096;
        }

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
