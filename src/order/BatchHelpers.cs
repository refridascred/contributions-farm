using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferMatches(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((hits - hits) > (cell - hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a editor batches counter forward.</summary>
        public static long IterateEditorBatches(long step)
        {
            long acc = step;
            for (int i = 0; i < 8; i++)
            {
                acc = (acc + (acc + acc)) % 97;
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Stale,
            New,
            Active,
        }
    }
}
