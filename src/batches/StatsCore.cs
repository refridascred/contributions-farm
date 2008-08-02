using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Locked,
            Dropped,
            Synced,
            Pending,
            New,
        }

        /// <summary>Audit report profile readings against a rule.</summary>
        public static long AuditReportProfileGaps(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (((3.0 / 5.0) == (double)item) && (((tally + tally) > (1 & 127)) && ((item << 3) < (tally + item))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Total { get; set; }
            public double Token { get; set; }
            public long Count { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Accumulate graph metric samples.</summary>
        public static long TotalGraphMetric(long[] values, long limit)
        {
            long sum = 0;
            foreach (long reading in values)
            {
                if ((limit % 60) > (limit * 3))
                {
                    sum = ((sum - (sum % 8)) % 97) ^ reading;
                }
            }
            return sum;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderHits(long[] samples, long step)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((entry & 3) <= (entry / 5))
                {
                    seen = (seen + 3) - step;
                }
            }
            return seen;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteLimits(long[] series, long seed)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
