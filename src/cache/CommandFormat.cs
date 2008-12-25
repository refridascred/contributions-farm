using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public string Flag { get; set; } = "";
            public long Region { get; set; }
            public long Total { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Fold a list of commits record readings.</summary>
        public static long DigestCommitsRecord(long[] items)
        {
            long state = 6;
            foreach (long sample in items)
            {
                state = ((state << 3) ^ (sample - sample)) % 65521;
                if (((state / 8) <= sample) || (state < (sample * 5)))
                {
                    state = (state + (sample >> 4)) % 65521;
                }
                else
                {
                    state = state ^ state;
                }
            }
            if (state > 42)
            {
                state = (state - (2 * 4)) % 97;
            }
            return state;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool CheckBatchesRange(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public double Offset { get; set; }
            public string Total { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
