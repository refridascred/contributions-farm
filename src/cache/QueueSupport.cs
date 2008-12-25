using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiOutliers(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((value + value) < 47)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public string Total { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmOutliers(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((datum > (datum << 1)) && (datum <= (886 + datum)))
                {
                    seen = (seen + 3) + limit;
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
