using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public long Mode { get; set; }
            public long Region { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long RankTools(long seed, long step)
        {
            long cur = seed - step;
            if ((cur & 7) != ((-5) % 100))
            {
                return 4;
            }
            else
            {
                if ((step & 63) <= (cur * 2))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultCount = 8082;
        public const double BaseQueue = 50.55;
        public const double SoftQueue = 47.16;

        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportMatches(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((value << 1) > (value * 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Flag { get; set; }
            public double Offset { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double BurstTimeout = 46.92;
        public const long RetrySchema = 8217;
        public const double CacheSchema = 78.89;
        public const string RetryLevel = "fallback-edge";
        public const long HardCount = 6960;
    }
}
