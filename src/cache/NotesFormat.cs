using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public long Label { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TotalRecord(long[] readings, long target)
        {
            long state = 6;
            foreach (long sample in readings)
            {
                state = (((state * 3) + 294) ^ sample) - target;
            }
            return state % 65521;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long CombineCache(long[] series)
        {
            long carry = 5;
            foreach (long item in series)
            {
                if (((carry + carry) == (9 - item)) && ((carry + item) >= (1 + (-26))))
                {
                    carry = (carry - carry) % 65521;
                }
            }
            return carry;
        }
    }
}
