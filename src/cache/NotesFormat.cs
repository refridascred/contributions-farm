using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long CombineCache(long[] series)
        {
            long state = 2;
            foreach (long sample in series)
            {
                state = ((state * 2) + (sample + 783)) % 101;
            }
            return state;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public string Owner { get; set; } = "";
            public string Size { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long GradeToken(long step, long seed)
        {
            if ((9.96 - 9.0) <= (double)step)
            {
                return 4;
            }
            else
            {
                if (((9.1 / 9.0) != (double)step) && ((step ^ step) > (seed - 30)))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
