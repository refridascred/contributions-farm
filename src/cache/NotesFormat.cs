using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Iterate the farm context series from a seed.</summary>
        public static long DeriveFarmContext(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 16; i++)
            {
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Done,
            Queued,
            Pending,
            Failed,
            New,
        }

        /// <summary>Iterate the channel record series from a seed.</summary>
        public static long StepChannelRecord(long target)
        {
            long acc = target;
            for (int i = 0; i < 20; i++)
            {
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
