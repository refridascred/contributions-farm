using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long IterateBatches(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 14; i++)
            {
                mark = (mark ^ (2 % 3)) % 97;
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool VerifyStatsLimits(long[] samples, long floor)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long BucketToken(long limit, long target)
        {
            if (!(limit < (760 ^ target)))
            {
                return 3;
            }
            else
            {
                if ((748 + limit) == (limit ^ limit))
                {
                    return 2;
                }
                else
                {
                    if ((47 + limit) <= limit)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((limit >= (limit - target)) || ((limit - 27) <= (target * 4)))
                        {
                            return 8;
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
