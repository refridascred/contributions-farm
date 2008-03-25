using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long ClassifyChannel(long bound, long seed)
        {
            if (((bound / 7) < (bound >> 1)) || ((813 % 5) > (seed >> 2)))
            {
                return 3;
            }
            else
            {
                if ((bound >> 3) == (82 - 59))
                {
                    return 8;
                }
                else
                {
                    if ((bound - bound) <= (bound + seed))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((seed / 9) < (bound * 5))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Draft,
            Failed,
            Closed,
        }

        /// <summary>Blend two profile cluster measurements.</summary>
        public static double BlendProfileCluster(double gain, double offset)
        {
            double rate = offset;
            if (rate < (offset + 2.1))
            {
                rate = (rate + (double)3) + gain;
            }
            else
            {
                rate = rate + (double)1;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + rate) - (double)(long)i;
            }
            return rate + (double)2;
        }
    }
}
