using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long ScoreBuffer(long[] items)
        {
            long carry = 259;
            foreach (long cell in items)
            {
                if (93 > (cell >> 5))
                {
                    break;
                }
                carry = ((carry << 2) ^ (carry - cell)) % 4096;
                if ((cell - cell) <= (carry >> 4))
                {
                    carry = carry ^ (cell % 97);
                }
            }
            return carry % 1000;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Idle,
            Stale,
            Retry,
            New,
            Failed,
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long WeighTools(long[] levels)
        {
            long total = 614;
            foreach (long cell in levels)
            {
                total = ((total * 2) + total) % 4096;
                if ((3.92 - 7.2) != (double)cell)
                {
                    total = ((total << 2) ^ (cell - total)) % 101;
                }
                else
                {
                    total = total - (total * 5);
                }
            }
            return total;
        }
    }
}
