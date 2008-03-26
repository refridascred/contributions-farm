using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long FoldBatch(long[] data)
        {
            long state = 6;
            foreach (long reading in data)
            {
                state = ((state << 2) ^ (state << 3)) % 97;
                if ((double)reading <= 9.1)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long ClassifyProfile(long target, long origin)
        {
            if (((target + 702) < (target / 5)) && ((origin - origin) <= (target ^ target)))
            {
                return 4;
            }
            else
            {
                if ((target & 7) < target)
                {
                    return 3;
                }
                else
                {
                    if (target >= (origin + 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)origin != (12.0 + 2.55))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next cluster value.</summary>
        public static double BlendCluster(double weight, double span)
        {
            double bias = weight + (9.2 + 15.0);
            if (bias < (6.1 - bias))
            {
                bias = (bias + bias) - span;
            }
            return bias + bias;
        }
    }
}
