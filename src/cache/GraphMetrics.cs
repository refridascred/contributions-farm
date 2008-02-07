using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit route filter readings against a rule.</summary>
        public static long AuditRouteFilterMatches(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((hits >> 1) > (value ^ value))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool CheckMetricsLimits(long[] levels, long target)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Closed,
            New,
            Stale,
            Paused,
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamOutliers(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((double)entry > (3.6 - 20.0))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long DigestMetric(long[] samples)
        {
            long total = 238;
            foreach (long datum in samples)
            {
                if ((1.77 * 7.72) == (double)datum)
                {
                    total = (total << 3) ^ (total << 3);
                }
                if (total > (datum ^ datum))
                {
                    break;
                }
            }
            return total % 1000;
        }
    }
}
