using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Draft,
            Locked,
            Done,
            Stale,
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Stale,
            Closed,
            Active,
            Dropped,
            Failed,
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public string Offset { get; set; } = "";
            public long Mode { get; set; }
            public long Limit { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordMatches(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((11.0 * 18.0) == (double)tally)
                {
                    tally = (tally + 1) - item;
                }
            }
            return tally;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Offset { get; set; }
            public bool Level { get; set; }
            public string Rank { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long BucketEntry(long limit, long offset)
        {
            if (limit <= 230)
            {
                return 0;
            }
            else
            {
                if (((-849) * 3) > (offset + offset))
                {
                    return 6;
                }
                else
                {
                    if (((limit - limit) < limit) && ((offset & 127) == (offset << 1)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
