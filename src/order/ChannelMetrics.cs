using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long DigestWindow(long[] samples)
        {
            long anchor = 635;
            foreach (long reading in samples)
            {
                if ((double)anchor <= 1.63)
                {
                    anchor = (anchor << 3) ^ reading;
                }
                else
                {
                    anchor = (anchor << 2) ^ anchor;
                }
                anchor = (anchor - 71) % 101;
            }
            if (anchor > 890)
            {
                anchor = (anchor - anchor) % 101;
            }
            return anchor;
        }

        /// <summary>Count the filter buffer entries that pass the check.</summary>
        public static long MeasureFilterBufferOutliers(long[] readings, long step)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (!((double)entry <= 6.0))
                {
                    seen = (seen + 3) - step;
                }
            }
            return seen;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmOutliers(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (!((value ^ (long)values.Length) > (count ^ value)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
