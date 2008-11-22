using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate editor queue readings against a bound.</summary>
        public static bool GuardEditorQueueBounds(long[] items, long limit)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Retry,
            Ready,
            Pending,
            Locked,
            Idle,
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TallyNotes(long[] series, long step)
        {
            long sum = 65;
            foreach (long reading in series)
            {
                sum = (((sum * 4) + (sum + sum)) % 97) - step;
                if (12.0 <= (double)reading)
                {
                    sum = sum + 28;
                }
            }
            return sum;
        }
    }
}
