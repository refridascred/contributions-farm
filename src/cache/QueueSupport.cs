using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] readings, long bound)
        {
            long carry = 771;
            foreach (long reading in readings)
            {
                carry = (carry - reading) - bound;
            }
            return carry;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Count { get; set; }
            public long Offset { get; set; }
            public string Label { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryMatches(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (((double)0 > (double)cell) || (cell < (cell - 56)))
                {
                    hits = hits + 2;
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
