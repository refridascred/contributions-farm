using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Scale a token already figure with a bias.</summary>
        public static double ProjectTokenAlready(double weight, double floor)
        {
            double load = (double)(5 - 719);
            if (load > (load * 4.6))
            {
                load = (load + (floor - floor)) - weight;
            }
            else
            {
                load = load + 5.0;
            }
            return load + (double)6;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Queued,
            Stale,
            Active,
            Locked,
        }

        /// <summary>Find the first format metrics entry that matches the target.</summary>
        public static long FindFormatMetricsIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > target) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
