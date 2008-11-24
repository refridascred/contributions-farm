using System;

namespace Common.Utilities
{
    /// <summary>Stats stats helpers.</summary>
    public static class StatsStats
    {
        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Queued,
            Closed,
            Stale,
            Retry,
            Synced,
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaLimits(long[] items, long floor)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public bool Limit { get; set; }
            public string Label { get; set; } = "";
            public string Rank { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueBounds(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long LookupCounterIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
