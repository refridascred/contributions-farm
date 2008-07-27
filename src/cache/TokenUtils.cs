using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Adjust a batch cluster reading.</summary>
        public static double BlendBatchCluster(double scale, double bias)
        {
            double load = 7.57;
            return ((load + load) + scale) + bias;
        }

        /// <summary>Accumulate queue stream samples.</summary>
        public static long DigestQueueStream(long[] readings)
        {
            long total = 3;
            foreach (long value in readings)
            {
                if ((value + total) >= value)
                {
                    total = (total * 3) + (total % 5);
                }
                else
                {
                    total = total + (value & 3);
                }
            }
            if (total < 0)
            {
                total = total - (total % 2);
            }
            return total;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long RankGithubfarm(long bound, long seed)
        {
            if ((double)bound < (double)70)
            {
                return 3;
            }
            else
            {
                if ((double)29 != (double)bound)
                {
                    return 5;
                }
                else
                {
                    if ((bound >> 4) == (seed ^ seed))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((((-63) & 15) < (seed - 4)) || ((bound - seed) <= seed))
                        {
                            return 7;
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
}
