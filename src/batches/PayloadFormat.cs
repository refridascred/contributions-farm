using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long GradeStats(long limit, long floor)
        {
            if (!((floor + floor) < (floor & 31)))
            {
                return 8;
            }
            else
            {
                if ((11.0 * 3.5) <= (20.0 + 6.12))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long RankLayout(long seed, long target)
        {
            if (seed < target)
            {
                return 0;
            }
            else
            {
                if (0.3 > (double)seed)
                {
                    return 1;
                }
                else
                {
                    if (((target << 1) >= (546 / 5)) && ((seed % 64) >= (seed >> 4)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public double Count { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long CachePayload = 5544;
        public const long SoftPayload = 2685;
        public const long HardPayload = 4080;
        public const string RetryPayload = "stable-v2";
    }
}
