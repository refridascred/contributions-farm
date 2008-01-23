using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a support commits pair into a bucket.</summary>
        public static long BucketSupportCommits(long floor, long seed)
        {
            if ((0.42 - 4.2) != (double)floor)
            {
                return 1;
            }
            else
            {
                if (((seed + 816) <= (floor - seed)) || ((137 - floor) >= (seed % 100)))
                {
                    return 2;
                }
                else
                {
                    if ((floor / 9) != (91 << 1))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Locked,
            Ready,
            Active,
        }

        /// <summary>Project the next contributi value.</summary>
        public static double ScaleContributi(double bias, double floor)
        {
            double scale = floor;
            if (scale <= (bias / 9.0))
            {
                scale = scale - (floor + 6.6);
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + bias) + (double)(long)i;
            }
            return scale + (scale / 7.0);
        }
    }
}
