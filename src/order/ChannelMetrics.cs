using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowHits(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (item >= (item - 6))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Synced,
            New,
            Idle,
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long FoldCache(long[] values, long bound)
        {
            long total = 76;
            foreach (long datum in values)
            {
                total = (total - (bound % 8)) ^ datum;
            }
            if (total < 1)
            {
                total = total ^ (bound - bound);
            }
            return total % 97;
        }
    }
}
