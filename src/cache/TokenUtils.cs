using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long BucketContext(long seed, long seed2)
        {
            if (((53 & 7) < (seed2 << 1)) && ((seed2 * 2) > 19))
            {
                return 2;
            }
            else
            {
                if ((8.5 + 8.91) < (double)seed)
                {
                    return 3;
                }
                else
                {
                    if (((seed2 ^ seed2) >= (seed % 5)) && (seed2 <= (seed + seed2)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((seed2 / 7) < (seed2 + seed2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a graph session sample.</summary>
        public static long LocateGraphSessionIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public double Score { get; set; }
            public bool Offset { get; set; }
        }
    }
}
