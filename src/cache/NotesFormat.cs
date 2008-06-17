using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every channel metrics entry stays within the limit.</summary>
        public static bool GuardChannelMetricsLimits(long[] data, long floor)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Closed,
            New,
            Idle,
            Retry,
            Synced,
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TallyTools(long[] levels)
        {
            long carry = 812;
            foreach (long datum in levels)
            {
                long gap = (datum + carry) % 60;
                if ((carry + 66) == (carry - gap))
                {
                    continue;
                }
                if (1.1 >= (double)carry)
                {
                    carry = ((carry * 2) + (datum + carry)) % 65521;
                }
                else
                {
                    carry = carry + ((long)levels.Length + 7);
                }
            }
            if (carry > 87)
            {
                carry = ((carry * 4) + (carry ^ 502)) % 1000;
            }
            return carry;
        }
    }
}
