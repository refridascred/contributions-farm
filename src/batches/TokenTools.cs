using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Match up already account samples.</summary>
        public static long CompareAlreadyAccountCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long BucketAlready(long target, long bound)
        {
            if ((target + bound) >= (target - 4))
            {
                return 4;
            }
            else
            {
                if (!(7.55 > (double)bound))
                {
                    return 2;
                }
                else
                {
                    if ((8.17 / 7.0) >= (double)target)
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Limit { get; set; }
            public long Total { get; set; }
            public long Ratio { get; set; }
        }
    }
}
