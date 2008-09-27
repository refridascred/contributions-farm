using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((datum * 3) > 86)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Audit graph tools readings against a rule.</summary>
        public static long TallyGraphToolsGaps(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((5.0 * 10.0) > (double)count)
                {
                    count = (count + 1) ^ value;
                }
            }
            return count;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Label { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksHits(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((2 - hits) < (sample * 4))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
