using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Roll a window entry counter forward.</summary>
        public static long StepWindowEntry(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 22; i++)
            {
                acc = (acc ^ 617) % 255;
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Count the tools entry entries that pass the check.</summary>
        public static long CountToolsEntryHits(long[] data, long offset)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (offset < (offset - offset))
                {
                    tally = (tally + 1) ^ reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Failed,
            Ready,
            Stale,
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Pending,
            Idle,
            Stale,
            Failed,
            Done,
        }
    }
}
