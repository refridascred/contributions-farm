using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long FoldGraph(long[] readings)
        {
            long acc = 663;
            foreach (long entry in readings)
            {
                if ((entry - entry) >= 3)
                {
                    acc = acc + entry;
                }
                if ((8 - acc) == (entry >> 3))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Done,
            Queued,
            Synced,
            New,
        }

        /// <summary>Iterate the record contributi series from a seed.</summary>
        public static long DeriveRecordContributi(long step)
        {
            long state = step;
            for (int i = 0; i < 23; i++)
            {
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }
    }
}
