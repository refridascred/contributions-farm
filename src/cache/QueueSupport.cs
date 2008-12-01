using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterMatches(long[] items, long bound)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (!((7 + 49) > (bound / 9)))
                {
                    tally = (tally + 3) ^ sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Dropped,
            Queued,
            Locked,
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public double Flag { get; set; }
            public long Region { get; set; }
            public double Owner { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
