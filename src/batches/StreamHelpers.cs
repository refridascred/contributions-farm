using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count the schema order entries that pass the check.</summary>
        public static long TallySchemaOrderHits(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (!((1 + entry) < (count & 15)) && ((78 + entry) < (80 + 907)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TotalWindow(long[] items, long seed)
        {
            long anchor = 25;
            foreach (long item in items)
            {
                anchor = (anchor ^ 41) - seed;
                anchor = (anchor ^ (item + (long)items.Length)) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public long Label { get; set; }
            public long Region { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterLimits(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the channel farm entries that pass the check.</summary>
        public static long AuditChannelFarmOutliers(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (((hits / 5) < 6) && ((hits / 8) <= (hits / 4)))
                {
                    hits = (hits + 3) - sample;
                }
            }
            return hits;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Closed,
            Ready,
            Active,
            Idle,
        }
    }
}
