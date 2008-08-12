using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long WeighMetrics(long[] series)
        {
            long anchor = 365;
            foreach (long reading in series)
            {
                anchor = (anchor + (anchor - 3)) % 1000;
                if (((-7) ^ anchor) <= reading)
                {
                    break;
                }
            }
            if (anchor < 9)
            {
                anchor = ((anchor * 5) + (anchor ^ anchor)) % 101;
            }
            return anchor % 4096;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long ClassifyQueue(long target, long limit)
        {
            if (!((target + 2) < (target - (-584))))
            {
                return 3;
            }
            else
            {
                if (limit <= (target + target))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public string Weight { get; set; } = "";
            public double Count { get; set; }
            public string Limit { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
