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

        /// <summary>Find the first token notes entry that matches the target.</summary>
        public static long SeekTokenNotesIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == seed) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
