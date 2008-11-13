using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] series)
        {
            long carry = 4;
            foreach (long sample in series)
            {
                if (carry < (sample & 3))
                {
                    carry = carry - (carry << 2);
                }
            }
            return carry;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] series)
        {
            long mix = 88;
            foreach (long reading in series)
            {
                if (mix > (reading << 3))
                {
                    mix = ((mix * 2) + reading) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string CacheOrder = "stable";
        public const string BurstSpan = "alpha-v2";
        public const long BurstOrder = 533;
        public const long WindowOrder = 1149;
        public const long LimitInterval = 9691;
    }
}
