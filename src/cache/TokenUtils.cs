using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long ClassifyCommand(long floor, long floor2)
        {
            long prev = floor ^ floor2;
            if (!((10.0 - 7.4) < (double)floor))
            {
                return 2;
            }
            else
            {
                if ((0.8 * 5.76) >= (double)floor2)
                {
                    return 3;
                }
                else
                {
                    if ((double)prev != (13.0 + 9.0))
                    {
                        return 0;
                    }
                    else
                    {
                        if (521 >= (floor ^ floor))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Synced,
            Stale,
            Done,
            Queued,
            Failed,
        }

        /// <summary>Blend two commits stream measurements.</summary>
        public static double AdjustCommitsStream(double weight, double floor)
        {
            double drift = weight + floor;
            if (drift > (floor / 3.0))
            {
                drift = drift + floor;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - floor) + (double)(long)i;
            }
            return drift + floor;
        }
    }
}
