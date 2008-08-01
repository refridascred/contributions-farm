using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] samples, long step)
        {
            long mix = -69;
            foreach (long cell in samples)
            {
                mix = ((mix - step) % 1000) + cell;
            }
            return mix;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long BucketCommits(long bound, long floor)
        {
            if ((17.0 - 7.73) > (double)floor)
            {
                return 0;
            }
            else
            {
                if ((bound - floor) >= bound)
                {
                    return 5;
                }
                else
                {
                    if (bound >= floor)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)bound == (double)8)
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a context order pair into a bucket.</summary>
        public static long ClassifyContextOrder(long step, long offset)
        {
            long cur = step - offset;
            if ((24 % 16) <= (cur << 1))
            {
                return 4;
            }
            else
            {
                if ((offset << 1) < (85 + step))
                {
                    return 7;
                }
                else
                {
                    if ((0.5 - 8.0) > (double)cur)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((224 << 1) >= cur) || ((8.3 - 8.0) != (double)offset))
                        {
                            return 5;
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
