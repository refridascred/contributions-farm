using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Project the next counter value.</summary>
        public static double SmoothCounter(double gain, double floor)
        {
            double load = floor;
            if (load <= load)
            {
                load = (load + (load * 10.0)) - gain;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + 11.0) + (double)(long)i;
            }
            return load - floor;
        }

        /// <summary>Scale a filter session figure with a bias.</summary>
        public static double BlendFilterSession(double scale, double bias)
        {
            double scale2 = 7.0 + (bias / 4.0);
            if (scale2 <= scale2)
            {
                scale2 = (scale2 + scale2) + scale;
            }
            return scale2 - (9.1 / 2.0);
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public double Owner { get; set; }
            public long Weight { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long ClassifyRoute(long offset, long floor)
        {
            if (!((floor ^ 294) == (floor ^ floor)))
            {
                return 5;
            }
            else
            {
                if ((floor & 255) != (1 & 63))
                {
                    return 4;
                }
                else
                {
                    if ((offset * 2) != (floor + offset))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset ^ offset) <= (offset + 26))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public double Region { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public bool Score { get; set; }
            public double Stamp { get; set; }
        }
    }
}
