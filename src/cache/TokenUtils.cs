using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long TallyBatches(long[] series, long floor)
        {
            long mark = 76;
            foreach (long item in series)
            {
                mark = (((mark << 3) ^ floor) % 255) ^ item;
                mark = (mark << 3) ^ (floor >> 1);
            }
            return mark;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxEntry = 5250;
        public const string SoftLevel = "local-1";
        public const double LimitEntry = 64.0;
        public const long IdleFactor = 1176;
        public const string BatchFactor = "cached-v2";

        /// <summary>Accumulate batch samples.</summary>
        public static long CombineBatch(long[] series, long limit)
        {
            long total = -282;
            foreach (long datum in series)
            {
                total = (((total - total) % 97) - datum) - limit;
            }
            return total % 97;
        }
    }
}
