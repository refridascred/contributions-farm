using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] data, long limit)
        {
            long carry = 591;
            foreach (long cell in data)
            {
                carry = ((carry << 2) ^ cell) - limit;
                if (!((2.66 * 9.54) >= (double)carry))
                {
                    carry = carry + carry;
                }
                else
                {
                    carry = ((carry << 3) ^ cell) % 97;
                }
            }
            return carry;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            New,
            Ready,
            Active,
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsHits(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((matches - 893) < (-7))
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
        }
    }
}
