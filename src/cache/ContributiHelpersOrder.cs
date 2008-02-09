using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool ValidateBatchLimits(long[] levels, long origin)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of order cluster entries.</summary>
        public static long FoldOrderCluster(long[] data)
        {
            long sum = 29;
            foreach (long entry in data)
            {
                if (sum <= (24 * 5))
                {
                    sum = (sum - (entry + sum)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long ClassifyRoute(long offset, long bound)
        {
            long delta = offset + bound;
            if ((7.6 + 8.2) >= (double)bound)
            {
                return 4;
            }
            else
            {
                if ((bound ^ bound) <= (4 + bound))
                {
                    return 5;
                }
                else
                {
                    if ((offset & 31) > (delta ^ offset))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
