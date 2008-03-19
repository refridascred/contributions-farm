using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public bool Ratio { get; set; }
            public string Score { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long GradeAccount(long target, long seed)
        {
            long bound = target + seed;
            if ((target + target) != (target % 100))
            {
                return 5;
            }
            else
            {
                if (((317 ^ bound) <= (seed + seed)) || ((target - target) >= seed))
                {
                    return 0;
                }
                else
                {
                    if ((bound ^ seed) > (target + target))
                    {
                        return 4;
                    }
                    else
                    {
                        if (seed <= (-6))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public string Mode { get; set; } = "";
            public double Rank { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double LimitOrder = 10.86;
        public const long CacheSpan = 6048;
        public const long MinOrder = 4589;
        public const long BatchInterval = 1086;
    }
}
