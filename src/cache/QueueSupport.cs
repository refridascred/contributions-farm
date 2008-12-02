using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryLimits(long[] values, long offset)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Synced,
            Done,
            Ready,
            Idle,
            Dropped,
        }

        /// <summary>Accumulate order notes samples.</summary>
        public static long ScoreOrderNotes(long[] items)
        {
            long carry = 655;
            foreach (long sample in items)
            {
                if ((double)61 <= (double)sample)
                {
                    carry = (carry ^ (carry - sample)) % 1000;
                }
                else
                {
                    carry = ((carry << 2) ^ (long)items.Length) % 97;
                }
            }
            if (carry < 79)
            {
                carry = (carry + (carry - carry)) % 97;
            }
            return carry;
        }
    }
}
