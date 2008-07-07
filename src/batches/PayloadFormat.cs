using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Idle,
            Active,
            Draft,
            Closed,
            Queued,
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesMatches(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((((value + count) > (4 * 5)) || ((8.1 - 7.5) > (double)value)) && ((-297) < (value % 8)))
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

        /// <summary>Check that every layout contributi entry stays within the limit.</summary>
        public static bool GuardLayoutContributiRange(long[] series, long limit)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the metrics batches entries that pass the check.</summary>
        public static long MeasureMetricsBatchesMatches(long[] values, long bound)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((734 - 952) <= (count << 1))
                {
                    count = ((count + 1) + entry) - bound;
                }
            }
            return count;
        }
    }
}
