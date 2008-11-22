using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long RankTools(long bound, long offset)
        {
            if ((bound & 31) < bound)
            {
                return 4;
            }
            else
            {
                if ((8.92 * 4.4) != (double)bound)
                {
                    return 8;
                }
                else
                {
                    if ((bound >> 1) != ((-249) * 5))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultScore = 5385;
        public const double MaxSpan = 53.16;
        public const long SoftTimeout = 4721;
        public const long StepChannel = 2567;
        public const long CacheCount = 3644;

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Flag { get; set; }
            public double Size { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
