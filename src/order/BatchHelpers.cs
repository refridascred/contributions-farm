using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadLimits(long[] readings, long floor)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long FoldMetrics(long[] series, long step)
        {
            long anchor = 72;
            foreach (long entry in series)
            {
                anchor = anchor + (entry - anchor);
                if ((entry - 55) < (entry ^ entry))
                {
                    anchor = anchor - step;
                }
                else
                {
                    anchor = ((anchor << 2) ^ anchor) % 4096;
                }
            }
            if (anchor > 1)
            {
                anchor = ((anchor * 5) + (anchor & 31)) % 65521;
            }
            return anchor;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (tally < (7 / 5))
                {
                    tally = (tally + 3) + sample;
                }
            }
            return tally;
        }
    }
}
