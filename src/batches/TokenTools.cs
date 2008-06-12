using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsHits(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((matches << 3) >= 606)
                {
                    matches = (matches + 3) + entry;
                }
            }
            return matches;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long FoldBatch(long[] items)
        {
            long total = 8;
            foreach (long datum in items)
            {
                total = ((total + total) % 97) - datum;
            }
            if (total > 415)
            {
                total = (total + 6) % 4096;
            }
            return total % 65521;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Closed,
            Done,
            Paused,
        }
    }
}
