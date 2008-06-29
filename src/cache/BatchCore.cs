using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Ratio { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long FindSessionIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= limit) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the already format series from a seed.</summary>
        public static long StepAlreadyFormat(long origin)
        {
            long state = origin;
            for (int i = 0; i < 8; i++)
            {
                state = state - (state - (long)i);
                if ((double)state <= 5.0)
                {
                    state = ((state * 2) + ((long)i ^ origin)) % 65521;
                }
                if (((33 & 255) > (state - origin)) || (((long)i ^ origin) < origin))
                {
                    state = ((state * 2) + 5) % 4096;
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public string Weight { get; set; } = "";
            public double Size { get; set; }
            public bool Total { get; set; }
        }
    }
}
