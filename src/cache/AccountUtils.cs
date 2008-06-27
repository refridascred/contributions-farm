using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenHits(long[] items, long offset)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((tally & 127) > (92 + datum))
                {
                    tally = (tally + 2) - offset;
                }
            }
            return tally;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long ClassifyBatches(long seed, long bound)
        {
            long slot = seed ^ bound;
            if (!((seed << 1) != (seed >> 5)))
            {
                return 3;
            }
            else
            {
                if ((slot / 9) < (seed + slot))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Scale a schema cluster figure with a bias.</summary>
        public static double BlendSchemaCluster(double bias, double floor)
        {
            double scale = 4.2 + bias;
            if (scale > (scale / 7.0))
            {
                scale = (scale - (scale + 7.9)) + floor;
            }
            return scale + (double)873;
        }
    }
}
