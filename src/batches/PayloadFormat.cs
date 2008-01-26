using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Queued,
            Closed,
            Draft,
            Failed,
            Paused,
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public double Size { get; set; }
            public long Region { get; set; }
            public long Label { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long CompareBatchCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordMatches(long[] items, long bound)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((double)seen <= (0.41 * 9.83))
                {
                    seen = ((seen + 3) ^ item) + bound;
                }
            }
            return seen;
        }
    }
}
