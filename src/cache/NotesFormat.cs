using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Closed,
            Queued,
            Locked,
            Done,
            Active,
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long PairContextCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandGaps(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((double)tally < 3.0)
                {
                    tally = (tally + 2) + value;
                }
            }
            return tally;
        }
    }
}
