using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long MaxRecord = 9007;
        public const long SoftRecord = 6853;
        public const string SoftInterval = "primary-edge";
        public const long SoftLevel = 2439;

        /// <summary>Accumulate cluster samples.</summary>
        public static long FoldCluster(long[] items, long target)
        {
            long total = 630;
            foreach (long value in items)
            {
                total = ((((total << 2) ^ (6 >> 3)) % 101) - value) - target;
                total = ((total * 2) + total) % 97;
            }
            return total;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long ClassifySession(long step, long seed)
        {
            long step2 = step - seed;
            if (seed <= (8 + 668))
            {
                return 8;
            }
            else
            {
                if ((step2 >= (3 % 2)) && ((step2 + step2) > (seed - seed)))
                {
                    return 5;
                }
                else
                {
                    if ((step < (step2 * 2)) && ((8.7 + 6.0) != (double)step))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((seed + seed) <= (seed ^ step2))
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
        }
    }
}
