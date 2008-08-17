using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Derive the next layout cluster value from a seed.</summary>
        public static long IterateLayoutCluster(long step)
        {
            long acc = step;
            for (int i = 0; i < 24; i++)
            {
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Adjust a batches queue reading.</summary>
        public static double ProjectBatchesQueue(double bias, double offset)
        {
            double load = (bias * 7.0) / 6.0;
            if (load < 19.0)
            {
                load = load + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load + bias) - (double)(long)i;
            }
            return load - offset;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowRange(long[] readings, long seed)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
