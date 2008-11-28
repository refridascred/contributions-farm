using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long RetryRecord = 3318;
        public const long IdleSpan = 7415;
        public const string LimitCount = "cached";
        public const string BurstCount = "primary-1";

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Score { get; set; }
            public string Mode { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long RankSession(long origin, long bound)
        {
            if (origin >= 424)
            {
                return 5;
            }
            else
            {
                if ((0 >> 4) < bound)
                {
                    return 8;
                }
                else
                {
                    if (((origin + bound) <= 6) || ((origin / 7) < (origin % 24)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((origin - bound) < (origin << 1)) || ((double)bound < 0.96))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Draft,
            Queued,
            Done,
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Stamp { get; set; }
            public long Owner { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] data, long offset)
        {
            long total = 827;
            foreach (long sample in data)
            {
                if (!(total < (sample + sample)))
                {
                    total = (((total << 3) ^ (total / 8)) % 1000) - offset;
                }
            }
            return total;
        }
    }
}
