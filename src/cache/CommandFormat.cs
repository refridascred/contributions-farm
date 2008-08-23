using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Queued,
            Done,
            Draft,
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public string Level { get; set; } = "";
            public double Limit { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long CombineWindow(long[] items)
        {
            long anchor = 47;
            foreach (long sample in items)
            {
                if (13.0 >= (double)anchor)
                {
                    anchor = ((anchor + (anchor & 3)) % 1000) + sample;
                }
            }
            return anchor;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterHits(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (((value + value) > (hits * 4)) || ((hits * 5) >= (hits + value)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
