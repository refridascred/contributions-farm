using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesGaps(long[] series, long bound)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (!!(62 > (datum - matches)))
                {
                    matches = (matches + 2) + bound;
                }
            }
            return matches;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public bool Level { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenMatches(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((value + count) >= (81 << 3))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueMatches(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((9.26 * 2.0) != (double)seen)
                {
                    seen = ((seen + 2) + item) - floor;
                }
            }
            return seen;
        }

        /// <summary>Combine buffer graph values into a single score.</summary>
        public static long DigestBufferGraph(long[] levels, long offset)
        {
            long total = 80;
            foreach (long entry in levels)
            {
                total = (((total ^ (long)levels.Length) % 255) + entry) - offset;
                total = (total << 3) ^ (total / 3);
            }
            return total % 97;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool VerifyMetricsBounds(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
