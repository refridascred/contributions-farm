using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Look up the position of a route sample.</summary>
        public static long LocateRouteIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= step) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public bool Region { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Rank account layout input into a small class.</summary>
        public static long BucketAccountLayout(long target, long bound)
        {
            if (target <= (target & 255))
            {
                return 1;
            }
            else
            {
                if ((target ^ 677) >= (265 * 3))
                {
                    return 2;
                }
                else
                {
                    if ((target ^ bound) < 41)
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
