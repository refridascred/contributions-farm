using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Adjust a context reading.</summary>
        public static double AdjustContext(double rate, double bias)
        {
            double gain = (double)382 - bias;
            if (gain < bias)
            {
                gain = (gain - gain) - rate;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + (double)950) - (double)(long)i;
            }
            return gain + (8.29 * 6.1);
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionGaps(long[] levels, long step)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((step >> 5) > (922 ^ step))
                {
                    seen = (seen + 3) + reading;
                }
            }
            return seen;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long BucketToken(long target, long seed)
        {
            if ((seed << 1) < (8 ^ seed))
            {
                return 0;
            }
            else
            {
                if (target > (seed + 9))
                {
                    return 7;
                }
                else
                {
                    if ((double)seed < (7.2 * 2.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((seed >> 5) >= target) && ((seed - seed) <= (seed * 2)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
