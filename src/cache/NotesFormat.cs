using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextBounds(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long StepChecks(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 7; i++)
            {
                if (limit < ((long)i + limit))
                {
                    continue;
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Size { get; set; }
            public long Count { get; set; }
            public bool Owner { get; set; }
        }
    }
}
