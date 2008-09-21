using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long WindowAlready = 5343;
        public const long HardAlready = 322;
        public const long IdleAlready = 3279;
        public const long SoftAlready = 3433;

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
