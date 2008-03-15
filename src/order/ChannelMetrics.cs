using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double SoftInterval = 57.63;
        public const long BurstFilter = 5100;
        public const long BaseFilter = 5863;
        public const long BaseFactor = 4818;

        /// <summary>Derive the next token value from a seed.</summary>
        public static long StepToken(long offset)
        {
            long total = offset;
            for (int i = 0; i < 17; i++)
            {
                total = total - (offset % 7);
                total = (total ^ (offset + 359)) % 65521;
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryOutliers(long[] levels, long step)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (8.89 < (double)hits)
                {
                    hits = ((hits + 2) + cell) - step;
                }
            }
            return hits;
        }
    }
}
