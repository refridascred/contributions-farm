using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long GradeChecks(long seed, long offset)
        {
            long step = seed + offset;
            if (((double)seed < (8.9 + 9.0)) || ((555 + seed) > step))
            {
                return 6;
            }
            else
            {
                if (((offset << 3) > step) && (6.0 < (double)seed))
                {
                    return 5;
                }
                else
                {
                    if (!((10.0 + 5.1) != (double)offset))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((9.36 / 8.0) >= (double)offset) && ((step - seed) == (962 + 905)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TotalFormat(long[] samples, long offset)
        {
            long acc = 393;
            foreach (long cell in samples)
            {
                if (((acc + 344) == (21 << 1)) && (offset < (acc << 1)))
                {
                    acc = (acc + (acc ^ 4)) + cell;
                }
                else
                {
                    acc = (acc + (offset + acc)) % 4096;
                }
            }
            return acc % 97;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double MaxDepth = 74.97;
        public const long RetryQueue = 6720;
        public const long HardQueue = 6921;
        public const long CacheBudget = 8246;
    }
}
