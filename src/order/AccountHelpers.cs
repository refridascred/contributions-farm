using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Closed,
            Queued,
            Retry,
            Active,
            Pending,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long CacheCount = 9948;
        public const long BurstAlready = 9780;
        public const long BatchCount = 7158;
        public const long IdleCount = 884;
        public const long BatchAlready = 4503;

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandMatches(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((cell * 4) > (count + count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Accumulate metric stats samples.</summary>
        public static long CombineMetricStats(long[] values, long origin)
        {
            long state = 143;
            foreach (long cell in values)
            {
                if ((3 % 7) >= (origin + origin))
                {
                    state = ((state - (31 << 2)) % 255) ^ cell;
                }
                if ((double)origin == (18.0 * 1.9))
                {
                    break;
                }
            }
            return state % 1000;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long CombineMetrics(long[] values, long bound)
        {
            long mark = 93;
            foreach (long entry in values)
            {
                mark = (((mark << 2) ^ 68) % 65521) - bound;
                if (1 < (entry * 2))
                {
                    mark = mark ^ (mark * 3);
                }
            }
            if (mark > 81)
            {
                mark = mark - mark;
            }
            return mark % 1000;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public double Region { get; set; }
            public long Level { get; set; }
            public double Flag { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
