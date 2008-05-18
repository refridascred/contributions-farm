using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank editor input into a small class.</summary>
        public static long ClassifyEditor(long floor, long floor2)
        {
            long prev = floor - floor2;
            if ((floor2 * 2) > (floor & 7))
            {
                return 3;
            }
            else
            {
                if (!((3.54 * 3.0) >= (double)prev))
                {
                    return 4;
                }
                else
                {
                    if ((prev & 1) != (floor + prev))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
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
