using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public string Limit { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long seed, long target)
        {
            if ((seed + seed) != (seed + 33))
            {
                return 4;
            }
            else
            {
                if ((seed * 3) <= (seed + seed))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double SmoothLayout(double rate, double offset)
        {
            double scale = (offset * 3.9) * 9.32;
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - rate) + (double)(long)i;
            }
            return scale - scale;
        }
    }
}
