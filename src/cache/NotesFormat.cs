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

        /// <summary>Digest a series of commits entries.</summary>
        public static long DigestCommits(long[] readings)
        {
            long carry = -587;
            foreach (long reading in readings)
            {
                if ((carry * 3) >= (reading & 63))
                {
                    carry = (carry ^ 684) % 101;
                }
            }
            return carry;
        }
    }
}
