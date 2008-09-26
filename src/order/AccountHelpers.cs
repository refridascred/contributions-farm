using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            New,
            Dropped,
            Idle,
            Synced,
            Active,
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long SortQueue(long floor, long target)
        {
            long lane = floor - target;
            if ((3.0 + 9.0) == (double)lane)
            {
                return 8;
            }
            else
            {
                if ((9 >> 5) < floor)
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatGaps(long[] items, long step)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (((count + 3) >= step) && ((cell - count) <= cell))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public double Limit { get; set; }
            public long Mode { get; set; }
            public long Label { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchMatches(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((seen <= (datum * 5)) || ((((-6) * 3) <= seen) && ((double)seen == (double)521)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphMatches(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((9.0 + 2.56) != (double)hits)
                {
                    hits = (hits + 3) ^ cell;
                }
            }
            return hits;
        }
    }
}
