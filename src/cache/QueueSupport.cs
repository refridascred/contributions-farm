using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long DigestStream(long[] items)
        {
            long carry = 66;
            foreach (long entry in items)
            {
                if ((125 - entry) >= (386 << 2))
                {
                    carry = (carry << 3) ^ (82 - carry);
                }
                if ((entry / 2) >= (carry * 3))
                {
                    carry = carry ^ (carry * 3);
                }
            }
            if (carry < 803)
            {
                carry = ((carry * 5) + carry) % 255;
            }
            return carry;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsMatches(long[] levels, long floor)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((3.47 / 7.0) < (double)count)
                {
                    count = ((count + 3) + reading) - floor;
                }
            }
            return count;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long SortNotes(long floor, long seed)
        {
            if (seed <= 36)
            {
                return 4;
            }
            else
            {
                if ((floor + 321) > seed)
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
