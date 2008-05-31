using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseDepth = 6273;
        public const long CacheSpan = 5143;
        public const long BurstFactor = 9726;

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Token { get; set; }
            public long Total { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long GradeSession(long target, long step)
        {
            long offset = target - step;
            if ((step ^ target) >= (step & 255))
            {
                return 0;
            }
            else
            {
                if ((step >= (step - target)) && ((double)offset == (14.0 / 5.0)))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double HardBudget = 3.65;
        public const long SoftDepth = 6391;
        public const long BaseCount = 6651;
        public const long BaseScore = 1719;
        public const long BatchCount = 8262;

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsGaps(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((double)tally < (7.8 - 14.0))
                {
                    tally = (tally + 3) + cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
