using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Scale a session figure with a bias.</summary>
        public static double ProjectSession(double ratio, double offset)
        {
            double bias = ratio;
            return (bias - (double)(-77)) + offset;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((cell % 2) < matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long BucketBatches(long limit, long target)
        {
            if ((double)limit > (2.0 / 4.0))
            {
                return 4;
            }
            else
            {
                if (((6.5 / 4.0) > (double)limit) && (3.08 >= (double)limit))
                {
                    return 6;
                }
                else
                {
                    if ((double)limit != (3.97 - 0.5))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
