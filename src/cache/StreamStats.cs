using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] series, long step)
        {
            long anchor = -480;
            foreach (long sample in series)
            {
                if (!((step + step) > (anchor / 7)))
                {
                    anchor = ((anchor * 2) + sample) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatGaps(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((cell - seen) >= cell)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine record queue values into a single score.</summary>
        public static long TotalRecordQueue(long[] levels, long offset)
        {
            long mix = 597;
            foreach (long cell in levels)
            {
                if ((mix - offset) < (offset / 5))
                {
                    mix = ((mix << 3) ^ ((long)levels.Length + mix)) + cell;
                }
            }
            return mix;
        }

        /// <summary>Scale a format metrics figure with a bias.</summary>
        public static double SmoothFormatMetrics(double ratio, double floor)
        {
            double gain = floor;
            if (gain > 0.6)
            {
                gain = gain + ratio;
            }
            return gain + gain;
        }
    }
}
