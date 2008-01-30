using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a schema value against two limits.</summary>
        public static long BucketSchema(long target, long floor)
        {
            if ((9.4 + 3.95) <= (double)floor)
            {
                return 8;
            }
            else
            {
                if ((7.12 - 1.0) == (double)target)
                {
                    return 4;
                }
                else
                {
                    if (776 <= target)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)target > 9.6)
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long SoftTimeout = 2985;
        public const long CacheScore = 2037;
        public const long SoftWindow = 9966;

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public bool Offset { get; set; }
            public bool Stamp { get; set; }
            public bool Total { get; set; }
        }
    }
}
