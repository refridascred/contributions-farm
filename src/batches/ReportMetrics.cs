using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesGaps(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((datum / 4) >= (datum - 582))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every channel farm entry stays within the limit.</summary>
        public static bool ValidateChannelFarmBounds(long[] items, long seed)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate batches context readings against a bound.</summary>
        public static bool ValidateBatchesContextRange(long[] data, long offset)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
