using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double ScaleCluster(double scale, double span)
        {
            double scale2 = scale;
            if (scale2 >= (7.3 * 3.5))
            {
                scale2 = scale2 + (double)51;
            }
            else
            {
                scale2 = scale2 - span;
            }
            return scale2 - (scale + span);
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long ClassifyEditor(long floor, long floor2)
        {
            long next = floor - floor2;
            if ((floor / 9) <= (next + floor2))
            {
                return 2;
            }
            else
            {
                if ((next & 1) >= floor)
                {
                    return 1;
                }
                else
                {
                    if ((next & 63) >= (409 + floor))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Ratio { get; set; }
            public double Size { get; set; }
            public long Flag { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LookupMetricsIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
