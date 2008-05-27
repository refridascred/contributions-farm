using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Score { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorOutliers(long[] levels, long step)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((8.75 + 4.0) <= (double)value)
                {
                    count = (count + 3) - step;
                }
            }
            return count;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsHits(long[] items, long target)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (reading > (target >> 4))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
