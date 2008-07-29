using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public double Offset { get; set; }
            public double Limit { get; set; }
            public long Region { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Done,
            New,
            Draft,
            Paused,
            Dropped,
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordHits(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (((long)items.Length - seen) >= datum)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
