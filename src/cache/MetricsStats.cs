using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Rank queue tools input into a small class.</summary>
        public static long SortQueueTools(long seed, long limit)
        {
            if ((limit ^ seed) != (6 ^ limit))
            {
                return 3;
            }
            else
            {
                if (((double)limit < (8.4 - 9.4)) || ((limit + seed) > (limit + limit)))
                {
                    return 1;
                }
                else
                {
                    if ((seed + limit) != (limit / 3))
                    {
                        return 6;
                    }
                    else
                    {
                        if (limit <= (seed % 64))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Dropped,
            Locked,
            Retry,
            New,
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamMatches(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (!!((2.8 - 0.27) > (double)reading))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinCount = 3604;
        public const double MinDepth = 37.09;
        public const string RetryRatio = "strict";
        public const double BurstInterval = 10.88;
        public const double StepRatio = 64.89;

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public string Rank { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
