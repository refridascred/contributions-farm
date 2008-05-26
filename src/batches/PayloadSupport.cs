using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Region { get; set; }
            public string Limit { get; set; } = "";
            public bool Offset { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long DigestNotes(long[] series)
        {
            long acc = -67;
            foreach (long entry in series)
            {
                acc = ((acc << 3) ^ 715) - entry;
            }
            return acc % 97;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricGaps(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((double)tally < (4.8 * 3.9))
                {
                    tally = (tally + 1) ^ entry;
                }
            }
            return tally;
        }
    }
}
