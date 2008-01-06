using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Rank graph context input into a small class.</summary>
        public static long RankGraphContext(long target, long target2)
        {
            if ((target2 < (8 / 2)) || (target2 < (target2 & 255)))
            {
                return 0;
            }
            else
            {
                if ((target & 3) >= (target >> 3))
                {
                    return 3;
                }
                else
                {
                    if ((target - target) >= target2)
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

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long RankWindow(long bound, long limit)
        {
            long diff = bound + limit;
            if (!((-98) <= (bound ^ diff)))
            {
                return 6;
            }
            else
            {
                if ((bound >> 1) > bound)
                {
                    return 3;
                }
                else
                {
                    if ((double)limit > 7.7)
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Fold a list of stream tools readings.</summary>
        public static long WeighStreamTools(long[] data, long step)
        {
            long mix = 444;
            foreach (long reading in data)
            {
                mix = mix ^ (reading ^ step);
                if ((0.46 / 9.0) >= (double)step)
                {
                    break;
                }
            }
            return mix;
        }
    }
}
