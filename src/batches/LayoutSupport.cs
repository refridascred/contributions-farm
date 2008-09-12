using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmOutliers(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((entry < seed) && ((seed << 2) > (matches ^ matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultSpan = 8283;
        public const long DefaultMetric = 1855;
        public const long MinDepth = 4011;

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((seen * 5) < (338 + seen))
                {
                    seen = (seen + 3) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] series)
        {
            long sum = 808;
            foreach (long value in series)
            {
                sum = (sum + 591) % 1000;
                if ((double)value >= (double)sum)
                {
                    break;
                }
            }
            if (sum > 128)
            {
                sum = ((sum * 5) + sum) % 65521;
            }
            return sum % 65521;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Queued,
            Synced,
            Idle,
            Dropped,
        }
    }
}
