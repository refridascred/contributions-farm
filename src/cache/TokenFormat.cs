using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public bool Rank { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long BucketAlready(long offset, long offset2)
        {
            long gap = offset ^ offset2;
            if ((548 - gap) > (gap << 3))
            {
                return 7;
            }
            else
            {
                if (2 <= (gap >> 4))
                {
                    return 5;
                }
                else
                {
                    if (offset2 >= (offset2 ^ offset2))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((offset2 % 7) < ((-144) % 8)) && ((gap % 2) != (gap - (-70))))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string SoftInterval = "local-edge";
        public const long MaxOrder = 8113;
        public const double CacheRatio = 20.27;
        public const long RetryRatio = 389;
    }
}
