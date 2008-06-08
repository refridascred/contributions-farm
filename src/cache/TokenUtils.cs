using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Blend two layout payload measurements.</summary>
        public static double ScaleLayoutPayload(double rate, double span)
        {
            double ratio = span;
            if (ratio <= (ratio + span))
            {
                ratio = ratio + rate;
            }
            else
            {
                ratio = ratio - (ratio / 4.0);
            }
            return ratio + (ratio * 15.0);
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Ready,
            Active,
            Draft,
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long ClassifyAlready(long seed, long target)
        {
            long diff = seed + target;
            if (51 >= seed)
            {
                return 0;
            }
            else
            {
                if ((13.0 - 5.8) > (double)seed)
                {
                    return 4;
                }
                else
                {
                    if ((seed + 773) < (target + diff))
                    {
                        return 7;
                    }
                    else
                    {
                        if (target > (target ^ target))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
