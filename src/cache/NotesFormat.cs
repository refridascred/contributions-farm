using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of farm format entries.</summary>
        public static long ScoreFarmFormat(long[] levels, long seed)
        {
            long carry = 28;
            foreach (long value in levels)
            {
                carry = ((carry - value) % 1000) - seed;
            }
            if (carry > 267)
            {
                carry = (carry - 94) % 65521;
            }
            return carry % 97;
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
