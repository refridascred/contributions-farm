using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Count { get; set; }
            public long Level { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Failed,
            Draft,
            Pending,
            Paused,
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool VerifyBatchesRange(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit support profile readings against a rule.</summary>
        public static long AuditSupportProfileOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (!((hits * 5) > (datum - datum)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
