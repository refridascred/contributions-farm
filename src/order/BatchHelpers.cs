using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public double Count { get; set; }
            public long Weight { get; set; }
            public long Total { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double AdjustMetrics(double gain, double bias)
        {
            double bias2 = (gain - gain) + bias;
            if (bias2 >= (bias2 / 5.0))
            {
                bias2 = bias2 + bias2;
            }
            return bias2 - (double)647;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long IterateRecord(long offset)
        {
            long state = offset;
            for (int i = 0; i < 4; i++)
            {
                state = state - state;
                if (state <= offset)
                {
                    state = (state << 3) ^ state;
                }
                if ((double)(-45) > (double)offset)
                {
                    state = state ^ (state + 1);
                }
                else
                {
                    state = (state - (offset + 5)) % 1000;
                    state = (state << 2) ^ 330;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }
    }
}
