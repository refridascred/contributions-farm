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

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueLimits(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
