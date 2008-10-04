using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesBounds(long[] items, long offset)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferHits(long[] items, long limit)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (!!((0 - entry) <= tally))
                {
                    tally = (tally + 1) - limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a format editor counter forward.</summary>
        public static long RollFormatEditor(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 14; i++)
            {
                mix = (mix - (mix >> 5)) % 101;
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
