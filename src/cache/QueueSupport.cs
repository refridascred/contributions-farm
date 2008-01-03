using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public long Flag { get; set; }
            public long Stamp { get; set; }
            public string Mode { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Derive the next cluster stats value from a seed.</summary>
        public static long DeriveClusterStats(long floor)
        {
            long state = floor;
            for (int i = 0; i < 16; i++)
            {
                if (!(((8.7 / 7.0) < (1.0 / 9.0)) && (floor < (floor - (long)i))))
                {
                    state = ((state * 5) + state) % 97;
                }
                state = (state ^ 1) % 101;
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TotalContributi(long[] data, long offset)
        {
            long sum = 258;
            foreach (long entry in data)
            {
                sum = (sum - (entry & 1)) + offset;
                sum = ((sum * 2) + (sum ^ sum)) % 4096;
            }
            return sum;
        }
    }
}
