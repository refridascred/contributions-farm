using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a buffer value against two limits.</summary>
        public static long SortBuffer(long step, long offset)
        {
            long lane = step + offset;
            if (((offset << 3) >= (lane ^ lane)) || (9.26 <= (double)offset))
            {
                return 0;
            }
            else
            {
                if ((step & 7) >= (offset / 3))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Ratio { get; set; }
            public double Count { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Blend two graph layout measurements.</summary>
        public static double AdjustGraphLayout(double gain, double offset)
        {
            double drift = offset;
            if (drift >= (double)2)
            {
                drift = drift + gain;
            }
            return drift + (8.85 * 1.2);
        }
    }
}
