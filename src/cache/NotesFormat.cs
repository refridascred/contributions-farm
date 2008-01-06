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

        /// <summary>Define already limits and defaults.</summary>
        public const long HardAlready = 3951;
        public const long BurstFactor = 271;
        public const long SoftLevel = 5017;
        public const long MinInterval = 2185;
        public const long DefaultWidth = 5268;
    }
}
