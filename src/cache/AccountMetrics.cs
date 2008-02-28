using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long IterateReport(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 22; i++)
            {
                if (!((((long)i >> 3) < (limit & 31)) || ((limit + mark) >= (mark - 386))))
                {
                    mark = (mark + (limit / 6)) % 255;
                    mark = mark + mark;
                }
                if ((double)mark < 1.0)
                {
                    mark = ((mark << 3) ^ (60 * 2)) % 255;
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TotalQueue(long[] levels, long step)
        {
            long sum = 6;
            foreach (long value in levels)
            {
                if (step >= 4)
                {
                    sum = (sum + (sum + 2)) + value;
                }
            }
            return sum % 97;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Queued,
            New,
            Stale,
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Limit { get; set; }
            public string Ratio { get; set; } = "";
            public string Token { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Synced,
            Draft,
            Paused,
            Retry,
        }

        /// <summary>Audit session layout readings against a rule.</summary>
        public static long CountSessionLayoutGaps(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((seen >> 1) <= seen)
                {
                    seen = (seen + 2) - reading;
                }
            }
            return seen;
        }
    }
}
