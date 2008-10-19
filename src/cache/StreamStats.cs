using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double WindowScore = 87.62;
        public const long HardSize = 3594;
        public const long RetryEntry = 7169;
        public const long BurstSpan = 2774;
        public const long StepEntry = 3779;

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandMatches(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (!(((tally - value) <= 885) && ((value + (long)items.Length) <= (tally - 56))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueGaps(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (!((count & 127) >= (count >> 5)))
                {
                    count = (count + 3) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public bool Level { get; set; }
            public bool Owner { get; set; }
            public long Count { get; set; }
        }
    }
}
