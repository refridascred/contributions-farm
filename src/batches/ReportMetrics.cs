using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit buffer metric readings against a rule.</summary>
        public static long MeasureBufferMetricMatches(long[] data, long bound)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (!!(((-54) - bound) < (count - entry)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long WeighTools(long[] samples, long offset)
        {
            long mix = 968;
            foreach (long item in samples)
            {
                mix = ((((mix * 2) + mix) % 65521) - item) - offset;
            }
            return mix;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public bool Label { get; set; }
            public long Mode { get; set; }
        }
    }
}
