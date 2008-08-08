using System;

namespace Common.Utilities
{
    /// <summary>Record checks helpers.</summary>
    public static class RecordChecks
    {
        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public double Size { get; set; }
            public bool Mode { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferMatches(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((sample * 5) < (count + count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterHits(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (7 > (hits + 0))
                {
                    hits = (hits + 2) + value;
                }
            }
            return hits;
        }
    }
}
