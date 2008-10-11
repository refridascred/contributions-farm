using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferGaps(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (((seen + seen) >= seen) || ((item << 1) != (item - item)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public string Mode { get; set; } = "";
            public long Size { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Measure how many metrics layout samples are out of range.</summary>
        public static long CountMetricsLayoutGaps(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((seen + sample) <= (sample + sample))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
