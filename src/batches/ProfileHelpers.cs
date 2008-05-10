using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Scale a graph figure with a bias.</summary>
        public static double AdjustGraph(double weight, double floor)
        {
            double scale = (double)(33 << 2);
            for (int i = 0; i < 6; i++)
            {
                scale = ((scale + (weight / 3.0)) + (double)(long)i) + floor;
            }
            return scale + (weight - 3.0);
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public double Ratio { get; set; }
            public double Label { get; set; }
            public long Score { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Dropped,
            Pending,
            Locked,
            New,
            Failed,
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double ScaleSchema(double bias, double span)
        {
            double load = (2.0 * 16.0) - (double)(-6);
            if (load > (double)90)
            {
                load = load - (span - bias);
            }
            else
            {
                load = load - (bias + 13.0);
            }
            return load + bias;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long SortQueue(long floor, long step)
        {
            if (((step >> 3) > 49) && ((double)step == (8.9 / 5.0)))
            {
                return 5;
            }
            else
            {
                if ((double)step == (17.0 * 18.0))
                {
                    return 3;
                }
                else
                {
                    if (((10.0 - 3.79) <= (double)step) || ((12.0 - 2.0) == (double)step))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderHits(long[] readings, long seed)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((count & 31) > (value & 63))
                {
                    count = (count + 3) + seed;
                }
            }
            return count;
        }
    }
}
