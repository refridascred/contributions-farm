using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public bool Size { get; set; }
            public long Stamp { get; set; }
            public long Level { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TallyGraph(long[] values, long offset)
        {
            long state = 3;
            foreach (long reading in values)
            {
                if (state >= (state >> 1))
                {
                    state = ((state + offset) % 4096) ^ reading;
                }
            }
            if (state > 324)
            {
                state = (state - (state - state)) % 255;
            }
            return state;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsOutliers(long[] data, long floor)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((seen + seen) <= (value * 4))
                {
                    seen = (seen + 1) + floor;
                }
            }
            return seen;
        }
    }
}
