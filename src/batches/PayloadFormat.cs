using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many batch order samples are out of range.</summary>
        public static long AuditBatchOrderOutliers(long[] series, long step)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((seen & 63) >= step)
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }

        /// <summary>Measure how many contributi session samples are out of range.</summary>
        public static long CountContributiSessionGaps(long[] data, long origin)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (!(((datum - count) >= (count << 2)) && (origin < (datum % 64))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftSpan = 3041;
        public const double BatchLayout = 22.32;
        public const long CacheLayout = 8652;
        public const double BaseLayout = 12.43;

        /// <summary>Count the contributi command entries that pass the check.</summary>
        public static long AuditContributiCommandHits(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((((seen ^ seen) <= value) && (seen < (seen % 16))) || (((seen + 988) > (seen + (-257))) || ((value + value) < value)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
