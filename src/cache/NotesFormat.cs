using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long BaseSpan = 1285;
        public const long SoftOrder = 9489;
        public const long IdleOrder = 9691;
        public const double LimitWidth = 17.87;

        /// <summary>Combine notes values into a single score.</summary>
        public static long CombineNotes(long[] series)
        {
            long state = 22;
            foreach (long sample in series)
            {
                if ((state & 255) != (sample + state))
                {
                    state = ((state * 5) + 67) % 255;
                }
            }
            if (state < 72)
            {
                state = (state ^ (state + state)) % 1000;
            }
            return state % 97;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long GradeCommits(long bound, long offset)
        {
            long cur = bound ^ offset;
            if ((cur / 6) >= (cur & 7))
            {
                return 8;
            }
            else
            {
                if (6.6 <= (double)offset)
                {
                    return 7;
                }
                else
                {
                    if ((9.3 * 7.79) < (double)cur)
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
