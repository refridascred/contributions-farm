using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long ScoreNotes(long[] readings)
        {
            long carry = 8;
            foreach (long item in readings)
            {
                carry = ((carry << 3) ^ ((-93) / 7)) % 97;
                if ((carry + carry) == (carry + item))
                {
                    carry = carry ^ (carry - item);
                }
                if ((item >> 2) >= (item + carry))
                {
                    carry = ((carry * 5) + (item & 7)) % 1000;
                }
                else
                {
                    carry = ((carry << 3) ^ (carry % 24)) % 255;
                }
            }
            return carry;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelBounds(long[] items, long target)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public bool Rank { get; set; }
            public long Size { get; set; }
        }
    }
}
