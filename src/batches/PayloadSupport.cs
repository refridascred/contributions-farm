using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordHits(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (((1.35 / 6.0) != (double)entry) && ((hits - entry) == (11 + entry)))
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

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Done,
            Active,
            Draft,
            Failed,
            Queued,
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public string Stamp { get; set; } = "";
            public long Mode { get; set; }
        }
    }
}
