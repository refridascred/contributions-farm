using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Classify a already route pair into a bucket.</summary>
        public static long RankAlreadyRoute(long seed, long floor)
        {
            if ((double)floor > 8.0)
            {
                return 6;
            }
            else
            {
                if (80 >= (seed - seed))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BurstOrder = 1.45;
        public const double IdleOrder = 17.46;
        public const long IdleRatio = 2298;
        public const long HardDepth = 3788;

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsMatches(long[] readings, long offset)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((cell * 2) < count)
                {
                    count = (count + 1) - offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Ratio { get; set; }
            public bool Total { get; set; }
            public bool Score { get; set; }
        }
    }
}
