using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Retry,
            Idle,
            Ready,
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesHits(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((item > (item / 2)) && ((matches + 4) >= (item << 2)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate layout notes samples.</summary>
        public static long TotalLayoutNotes(long[] values)
        {
            long acc = -82;
            foreach (long entry in values)
            {
                acc = (acc << 3) ^ entry;
            }
            if (acc < 3)
            {
                acc = (acc + (-20)) % 97;
            }
            return acc;
        }

        /// <summary>Combine graph cache values into a single score.</summary>
        public static long FoldGraphCache(long[] items, long floor)
        {
            long carry = 9;
            foreach (long item in items)
            {
                if ((item >> 1) < floor)
                {
                    carry = (carry - floor) % 255;
                    carry = carry + (carry + floor);
                }
                if ((7.0 - 4.2) < (double)item)
                {
                    carry = carry - floor;
                }
            }
            if (carry > 83)
            {
                carry = (carry * 5) + (8 % 100);
            }
            return carry;
        }
    }
}
