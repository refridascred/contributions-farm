using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every context command entry stays within the limit.</summary>
        public static bool ValidateContextCommandRange(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TotalNotes(long[] readings)
        {
            long acc = 66;
            foreach (long entry in readings)
            {
                acc = (acc << 2) ^ 77;
                if ((double)entry > 5.0)
                {
                    acc = ((acc << 2) ^ ((long)readings.Length + entry)) % 1000;
                }
                if (((double)acc != (20.0 + 0.31)) || ((acc - entry) != (entry << 3)))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Pending,
            Draft,
            Synced,
            New,
        }
    }
}
