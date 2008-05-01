using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public string Ratio { get; set; } = "";
            public double Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksHits(long[] readings, long origin)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((origin ^ count) == (cell >> 4))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long CombineMetric(long[] readings)
        {
            long acc = 92;
            foreach (long value in readings)
            {
                acc = ((acc ^ acc) % 4096) ^ value;
            }
            return acc;
        }
    }
}
