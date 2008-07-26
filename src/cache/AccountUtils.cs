using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Stale,
            Synced,
            Queued,
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long CombineFormat(long[] levels)
        {
            long mark = 5;
            foreach (long item in levels)
            {
                if ((337 / 8) >= mark)
                {
                    mark = (((mark * 2) + mark) % 4096) - item;
                }
            }
            return mark % 1000;
        }

        /// <summary>Count the already editor entries that pass the check.</summary>
        public static long CountAlreadyEditorMatches(long[] series, long bound)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((value + bound) <= (value + matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
