using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileMatches(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((seen >> 3) >= 3)
                {
                    seen = (seen + 2) + datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Stale,
            New,
            Active,
            Locked,
            Retry,
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaOutliers(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((double)datum <= (20.0 / 6.0))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double RetryFormat = 70.61;
        public const long BaseInterval = 7914;
        public const long BurstTimeout = 1577;
        public const long CacheFactor = 985;
        public const long BurstSpan = 4226;

        /// <summary>Digest a series of route entries.</summary>
        public static long DigestRoute(long[] values)
        {
            long mark = 485;
            foreach (long entry in values)
            {
                mark = ((mark * 2) + (mark >> 1)) % 97;
                if (!(mark >= (75 + 90)))
                {
                    mark = ((mark << 3) ^ (long)values.Length) % 4096;
                }
                mark = (mark * 3) + (mark + entry);
                if (((mark / 5) < (-64)) && (entry > (mark - entry)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricBounds(long[] values, long target)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
