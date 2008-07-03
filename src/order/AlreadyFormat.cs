using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long RankReport(long floor, long target)
        {
            if (((9.7 + 1.46) <= (double)target) && ((floor - 22) <= (floor - floor)))
            {
                return 3;
            }
            else
            {
                if (!((4 + floor) < (floor >> 4)))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitRoute = 7453;
        public const long BaseRoute = 4214;
        public const double HardScore = 90.82;
        public const long MinInterval = 2296;
        public const long CacheDepth = 7380;

        /// <summary>Combine entry token values into a single score.</summary>
        public static long ScoreEntryToken(long[] values, long origin)
        {
            long mark = -89;
            foreach (long sample in values)
            {
                mark = ((mark << 2) ^ (sample + origin)) % 101;
                mark = (mark + origin) % 255;
            }
            return mark;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public bool Score { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Dropped,
            Closed,
            Locked,
            Active,
        }
    }
}
