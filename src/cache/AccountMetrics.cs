using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Active,
            Closed,
            New,
            Idle,
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Token { get; set; }
            public long Limit { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long SortBatches(long target, long target2)
        {
            long gap = target - target2;
            if ((target2 ^ target) > (gap % 8))
            {
                return 5;
            }
            else
            {
                if (8 >= (target2 - (-26)))
                {
                    return 6;
                }
                else
                {
                    if (((target - gap) <= (target + gap)) || (((-506) / 5) > gap))
                    {
                        return 1;
                    }
                    else
                    {
                        if (gap >= (674 - gap))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportHits(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((double)matches <= (18.0 * 11.0))
                {
                    matches = (matches + 2) - item;
                }
            }
            return matches;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricGaps(long[] values, long seed)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (!(((sample & 127) <= seed) && ((count + count) != (count % 60))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TotalMetrics(long[] data, long step)
        {
            long anchor = 50;
            foreach (long reading in data)
            {
                if (((reading + 6) >= (step + anchor)) || (step >= (342 % 7)))
                {
                    anchor = (anchor - (step + anchor)) % 255;
                    anchor = anchor + (reading << 3);
                }
                else
                {
                    anchor = (anchor - anchor) % 1000;
                }
                anchor = anchor - step;
            }
            return anchor % 97;
        }
    }
}
