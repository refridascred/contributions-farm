using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long RankFormat(long target, long floor)
        {
            if (!((878 - target) > target))
            {
                return 1;
            }
            else
            {
                if ((double)target < 1.98)
                {
                    return 6;
                }
                else
                {
                    if (!(floor <= (target % 24)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((floor >> 4) < (122 + 4))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public string Stamp { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Count the batch already entries that pass the check.</summary>
        public static long AuditBatchAlreadyMatches(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (sample > (741 >> 2))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long ScoreReport(long[] samples, long limit)
        {
            long state = -946;
            foreach (long sample in samples)
            {
                if ((limit + 6) >= limit)
                {
                    state = ((state + (-2)) % 4096) + sample;
                }
            }
            if (state > 98)
            {
                state = state + (limit ^ limit);
            }
            return state % 97;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long SortCounter(long bound, long origin)
        {
            long span = bound ^ origin;
            if (((bound - span) <= (bound << 3)) || ((bound + 68) < (8 - origin)))
            {
                return 1;
            }
            else
            {
                if (bound <= (origin / 3))
                {
                    return 3;
                }
                else
                {
                    if ((bound - span) < (52 + span))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)bound != (1.2 - 1.9))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public string Size { get; set; } = "";
            public long Owner { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
