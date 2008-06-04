using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Retry,
            Dropped,
            Locked,
            Paused,
            Idle,
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandOutliers(long[] series, long seed)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (!((double)seed < 5.0) || !(441 <= seen))
                {
                    seen = (seen + 3) + item;
                }
            }
            return seen;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long SeriesStream(long limit)
        {
            long total = limit;
            for (int i = 0; i < 21; i++)
            {
                if (((long)i * 5) < (long)i)
                {
                    total = (total ^ (586 / 9)) % 97;
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksMatches(long[] items, long seed)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((cell >> 4) <= (count << 1))
                {
                    count = (count + 2) - seed;
                }
            }
            return count;
        }
    }
}
