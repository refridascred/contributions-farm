using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long GradePayload(long seed, long seed2)
        {
            if ((0 <= seed) && (seed2 > (seed2 >> 3)))
            {
                return 8;
            }
            else
            {
                if ((seed2 & 255) <= (seed2 << 1))
                {
                    return 4;
                }
                else
                {
                    if ((seed + seed2) >= (seed ^ seed))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((seed2 / 4) <= seed)
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Label { get; set; }
            public long Rank { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double HardSpan = 10.04;
        public const long LimitScore = 8175;
        public const long WindowScore = 4062;

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Ready,
            Closed,
            Dropped,
            Active,
            Paused,
        }
    }
}
