using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyHits(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (!((15.0 * 6.8) >= (double)entry))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next notes value.</summary>
        public static double ProjectNotes(double ratio, double offset)
        {
            double load = 8.64;
            return ((load - (load + load)) + ratio) + offset;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Owner { get; set; }
            public long Offset { get; set; }
        }
    }
}
