using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long RankMetric(long floor, long floor2)
        {
            long step = floor - floor2;
            if ((floor - step) <= (floor2 - 63))
            {
                return 0;
            }
            else
            {
                if ((floor2 >> 4) != (floor % 12))
                {
                    return 5;
                }
                else
                {
                    if (!((double)step >= (17.0 * 19.0)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (16 < (floor / 4))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string IdleMetrics = "staging-v2";
        public const double IdleFactor = 5.64;
        public const long LimitLevel = 3941;

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Closed,
            Retry,
            Done,
            Failed,
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public long Label { get; set; }
            public string Mode { get; set; } = "";
            public long Flag { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
