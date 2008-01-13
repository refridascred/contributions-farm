using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string RetryRatio = "local";
        public const long SoftRecord = 7419;
        public const double DefaultInterval = 84.09;
        public const long DefaultRecord = 7660;
        public const long RetryLevel = 8753;

        /// <summary>Roll a layout contributi counter forward.</summary>
        public static long RollLayoutContributi(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 6; i++)
            {
                if ((long)i > (sum + sum))
                {
                    break;
                }
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Derive the next already context value from a seed.</summary>
        public static long SeriesAlreadyContext(long offset)
        {
            long total = offset;
            for (int i = 0; i < 9; i++)
            {
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }
    }
}
