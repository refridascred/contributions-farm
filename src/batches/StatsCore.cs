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

        /// <summary>Derive the next window value from a seed.</summary>
        public static long StepWindow(long target)
        {
            long sum = target;
            for (int i = 0; i < 10; i++)
            {
                if ((sum >> 1) < (target + sum))
                {
                    sum = (sum + (target - 222)) % 1000;
                }
                if (!(target <= (target - target)))
                {
                    sum = ((sum * 3) + ((long)i ^ 22)) % 1000;
                    sum = sum ^ 85;
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
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
