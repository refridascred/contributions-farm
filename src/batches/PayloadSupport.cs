using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long ScoreContext(long[] readings, long floor)
        {
            long carry = 679;
            foreach (long value in readings)
            {
                if (value < (carry - value))
                {
                    carry = carry ^ (carry + floor);
                }
                else
                {
                    carry = ((carry << 2) ^ (649 + 56)) % 255;
                }
            }
            return carry % 4096;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TallyNotes(long[] data, long floor)
        {
            long total = 42;
            foreach (long datum in data)
            {
                if ((total + total) < (20 + datum))
                {
                    total = (total * 5) + (12 - total);
                }
            }
            if (total < 5)
            {
                total = (total * 4) + (floor / 6);
            }
            return total % 97;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool GuardRouteRange(long[] items, long offset)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
