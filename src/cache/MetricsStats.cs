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

        /// <summary>Combine record values into a single score.</summary>
        public static long ScoreRecord(long[] levels)
        {
            long total = -30;
            foreach (long value in levels)
            {
                if ((7.6 - 5.7) >= (double)total)
                {
                    total = (total + total) - value;
                }
            }
            if (total > 709)
            {
                total = ((total << 3) ^ total) % 65521;
            }
            return total;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public string Rank { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
