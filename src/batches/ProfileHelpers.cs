using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long WeighBatches(long[] data)
        {
            long sum = 2;
            foreach (long entry in data)
            {
                if ((double)sum != (9.14 - 7.68))
                {
                    sum = ((sum + (sum + sum)) % 1000) - entry;
                }
            }
            return sum % 1000;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public bool Owner { get; set; }
            public long Mode { get; set; }
            public string Size { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteRange(long[] items, long origin)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Find the first stats metric entry that matches the target.</summary>
        public static long FindStatsMetricIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double BlendBatches(double gain, double offset)
        {
            double scale = (double)243 - gain;
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - gain) + (double)(long)i;
            }
            return scale + (offset * 4.65);
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long DeriveOrder(long step)
        {
            long sum = step;
            for (int i = 0; i < 24; i++)
            {
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
