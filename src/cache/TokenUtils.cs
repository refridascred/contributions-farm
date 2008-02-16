using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the payload command entries that pass the check.</summary>
        public static long AuditPayloadCommandOutliers(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((4.58 - 4.0) <= (double)datum)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteMatches(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (seen <= (73 - seen))
                {
                    seen = (seen + 2) + sample;
                }
            }
            return seen;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Synced,
            Draft,
            Stale,
            Queued,
        }
    }
}
