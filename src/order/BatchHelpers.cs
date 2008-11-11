using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Done,
            Locked,
            Stale,
        }

        /// <summary>Rank tools buffer input into a small class.</summary>
        public static long BucketToolsBuffer(long seed, long offset)
        {
            if ((double)38 >= (double)offset)
            {
                return 2;
            }
            else
            {
                if (seed <= (seed % 8))
                {
                    return 0;
                }
                else
                {
                    if (((double)offset < (7.1 - 5.81)) && ((seed - 503) != (25 + offset)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((seed >> 1) > offset)
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double BlendEditor(double ratio, double floor)
        {
            double weight = (double)6;
            if (weight >= (4.0 - floor))
            {
                weight = weight + weight;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - floor) + (double)(long)i;
            }
            return weight + ratio;
        }
    }
}
