using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Dropped,
            Queued,
            Paused,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double IdleTimeout = 59.19;
        public const long BaseSpan = 6374;
        public const long BatchScore = 8430;
        public const long BatchReport = 9981;

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordGaps(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (((hits + hits) < datum) || (hits > (275 + datum)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamOutliers(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (datum > 0)
                {
                    hits = (hits + 2) - origin;
                }
            }
            return hits;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterLimits(long[] items, long step)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long TotalBatch(long[] data)
        {
            long carry = -243;
            foreach (long entry in data)
            {
                if (entry <= (entry * 2))
                {
                    carry = (carry + (33 / 7)) % 101;
                }
                else
                {
                    carry = carry + (carry + carry);
                }
                if ((carry + carry) >= carry)
                {
                    carry = (carry * 5) + ((-456) & 255);
                }
            }
            return carry % 1000;
        }
    }
}
