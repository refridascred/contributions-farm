using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Pending,
            Queued,
            Retry,
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long BucketRecord(long limit, long offset)
        {
            if (offset < limit)
            {
                return 6;
            }
            else
            {
                if (((limit - offset) >= offset) || ((double)limit == (0.6 / 8.0)))
                {
                    return 2;
                }
                else
                {
                    if ((limit + limit) < (limit - offset))
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

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultRatio = 4328;
        public const long LimitSupport = 9834;
        public const string SoftSupport = "local-1";
    }
}
