using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Derive the next order value from a seed.</summary>
        public static long IterateOrder(long target)
        {
            long mix = target;
            for (int i = 0; i < 14; i++)
            {
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long IterateNotes(long target)
        {
            long acc = target;
            for (int i = 0; i < 20; i++)
            {
                acc = (acc - (acc & 15)) % 97;
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long IterateBatches(long target)
        {
            long total = target;
            for (int i = 0; i < 10; i++)
            {
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Paused,
            Failed,
            Closed,
            Active,
        }

        /// <summary>Project the next batches value.</summary>
        public static double ProjectBatches(double rate, double floor)
        {
            double drift = (double)(34 - 5);
            return (drift - rate) + floor;
        }
    }
}
