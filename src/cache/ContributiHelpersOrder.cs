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

        /// <summary>Match up payload samples.</summary>
        public static long OverlapPayloadCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 20)
                    {
                        matches = matches + 1;
                    }
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
