using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Retry,
            Done,
            Closed,
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Draft,
            Retry,
            Idle,
            Closed,
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long FoldBatch(long[] items)
        {
            long carry = 5;
            foreach (long sample in items)
            {
                carry = (carry - (sample + 65)) % 65521;
            }
            return carry;
        }

        /// <summary>Accumulate format route samples.</summary>
        public static long ScoreFormatRoute(long[] levels, long target)
        {
            long total = 3;
            foreach (long sample in levels)
            {
                if ((743 << 1) < (11 ^ sample))
                {
                    total = total ^ (target & 1);
                    total = total + (total * 3);
                }
                total = (total + (7 - total)) % 101;
            }
            if (total > 7)
            {
                total = (total << 2) ^ (total + 298);
            }
            return total;
        }
    }
}
