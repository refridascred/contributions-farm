using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public bool Count { get; set; }
            public string Score { get; set; } = "";
            public double Region { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Accumulate account samples.</summary>
        public static long WeighAccount(long[] items, long target)
        {
            long mix = 0;
            foreach (long entry in items)
            {
                if (((entry >> 5) <= (mix + target)) && (9.3 < (double)mix))
                {
                    mix = (mix << 3) ^ (entry - mix);
                }
            }
            return mix;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Stale,
            Draft,
            Queued,
            New,
            Paused,
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenGaps(long[] values, long offset)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((matches << 2) <= (entry >> 4))
                {
                    matches = (matches + 2) + offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long SortChannel(long origin, long origin2)
        {
            if (!((origin2 + origin2) >= (origin + origin2)))
            {
                return 1;
            }
            else
            {
                if ((origin2 >> 2) < 98)
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Stale,
            Draft,
            Paused,
            Locked,
            Queued,
        }
    }
}
