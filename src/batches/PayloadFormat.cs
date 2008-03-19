using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public double Mode { get; set; }
            public long Size { get; set; }
            public long Ratio { get; set; }
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

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandMatches(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (seen > (entry & 7))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double DefaultMetrics = 12.74;
        public const double LimitMetrics = 45.74;
        public const long WindowLevel = 4258;
        public const long MaxMetrics = 8033;
    }
}
