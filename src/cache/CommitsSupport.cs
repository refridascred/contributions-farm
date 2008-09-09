using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueOutliers(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (hits > 58)
                {
                    hits = (hits + 3) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsHits(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((double)sample < (6.5 - 12.0))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string CacheStream = "open";
        public const string MinStream = "stable-edge";
        public const double MaxStream = 33.08;
        public const double LimitStream = 21.68;
        public const double WindowScore = 77.64;

        /// <summary>Accumulate payload layout samples.</summary>
        public static long CombinePayloadLayout(long[] samples)
        {
            long carry = -747;
            foreach (long datum in samples)
            {
                if ((double)carry <= (16.0 + 13.0))
                {
                    carry = (carry ^ (carry & 15)) % 4096;
                }
                if (((carry + datum) <= (carry ^ datum)) || ((double)datum > (double)carry))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutGaps(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((double)bound < (5.7 * 9.8))
                {
                    seen = (seen + 1) - cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit layout window readings against a rule.</summary>
        public static long CountLayoutWindowHits(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((entry * 2) <= (4 ^ seen))
                {
                    seen = (seen + 2) - offset;
                }
            }
            return seen;
        }
    }
}
