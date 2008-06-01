using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public double Weight { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long WeighFormat(long[] items, long floor)
        {
            long anchor = 0;
            foreach (long reading in items)
            {
                anchor = ((anchor ^ reading) % 255) - floor;
            }
            return anchor;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long GradeFarm(long step, long seed)
        {
            long next = step + seed;
            if ((step <= (seed & 127)) && ((19.0 - 7.8) >= (double)seed))
            {
                return 7;
            }
            else
            {
                if ((next > (seed * 5)) || ((seed - step) <= next))
                {
                    return 2;
                }
                else
                {
                    if (((next >> 2) >= (next << 3)) && ((double)next < 8.59))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
