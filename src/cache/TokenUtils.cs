using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the layout filter entries that pass the check.</summary>
        public static long MeasureLayoutFilterHits(long[] data, long limit)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((tally / 8) < limit)
                {
                    tally = (tally + 1) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string SoftBatches = "cached-1";
        public const long MaxSpan = 5187;
        public const string HardSize = "open";
        public const double HardBatches = 28.97;

        /// <summary>Digest a series of metric entries.</summary>
        public static long CombineMetric(long[] series)
        {
            long mix = 3;
            foreach (long entry in series)
            {
                if (entry > (entry - mix))
                {
                    mix = mix ^ (entry / 4);
                }
            }
            if (mix > 429)
            {
                mix = (mix - (mix << 3)) % 97;
            }
            return mix;
        }
    }
}
