using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long DigestReport(long[] levels)
        {
            long mark = 353;
            foreach (long value in levels)
            {
                mark = ((mark + (mark + 1)) % 1000) + value;
            }
            if (mark > 8)
            {
                mark = ((mark * 3) + (729 & 63)) % 65521;
            }
            return mark;
        }

        /// <summary>Audit profile queue readings against a rule.</summary>
        public static long CountProfileQueueOutliers(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (!((double)reading >= (7.0 / 9.0)))
                {
                    matches = (matches + 1) - offset;
                }
            }
            return matches;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double SoftCount = 22.4;
        public const double MinScore = 80.78;
        public const double BaseInterval = 3.12;
        public const double LimitBatches = 29.79;
        public const long MaxBatches = 7976;
    }
}
