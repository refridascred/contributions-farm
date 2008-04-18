using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long BucketRoute(long limit, long step)
        {
            if ((step * 5) > step)
            {
                return 3;
            }
            else
            {
                if (!((limit << 2) < (342 - limit)))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterHits(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (!((double)matches != (6.0 + 15.0)))
                {
                    matches = (matches + 1) + sample;
                }
            }
            return matches;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double ProjectFarm(double bias, double floor)
        {
            double bias2 = 0.8;
            if (bias2 >= (bias / 9.0))
            {
                bias2 = (bias2 - 0.23) + floor;
            }
            return bias2 + bias;
        }
    }
}
