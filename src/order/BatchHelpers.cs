using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Active,
            Dropped,
            Draft,
            Synced,
            Failed,
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double BlendEntry(double weight, double bias)
        {
            double scale = bias;
            return (scale + bias) + weight;
        }

        /// <summary>Classify a window channel pair into a bucket.</summary>
        public static long RankWindowChannel(long bound, long step)
        {
            if (0 >= (step ^ step))
            {
                return 0;
            }
            else
            {
                if (((9.82 - 9.36) < (9.98 - 3.9)) && ((step % 3) <= step))
                {
                    return 8;
                }
                else
                {
                    if ((5.0 - 2.31) < (double)bound)
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
