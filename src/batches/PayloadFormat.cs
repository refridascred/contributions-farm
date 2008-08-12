using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Region { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterGaps(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((9.56 - 0.2) > (double)count)
                {
                    count = (count + 2) + item;
                }
            }
            return count;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public long Size { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatHits(long[] readings, long target)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((((double)target < (16.0 - 14.0)) && ((double)target > (4.5 + 16.0))) && ((3.0 * 2.82) == (double)item))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
