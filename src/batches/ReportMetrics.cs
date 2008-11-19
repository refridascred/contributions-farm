using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Roll a stream counter forward.</summary>
        public static long RollStream(long step)
        {
            long carry = step;
            for (int i = 0; i < 13; i++)
            {
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftCommand = 3438;
        public const long CacheRatio = 7809;
        public const long BatchRatio = 7885;
        public const long CacheCommand = 7036;
        public const string BaseCommand = "latest";

        /// <summary>Roll a buffer counter forward.</summary>
        public static long SeriesBuffer(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 23; i++)
            {
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }
    }
}
