using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] series)
        {
            long anchor = 555;
            foreach (long item in series)
            {
                if (item < (anchor >> 4))
                {
                    anchor = anchor - (59 << 3);
                }
                if (((anchor + (long)series.Length) != (anchor + 2)) && ((double)anchor > (3.29 * 12.0)))
                {
                    break;
                }
            }
            return anchor % 97;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Label { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long origin, long step)
        {
            long bound = origin - step;
            if ((origin ^ step) == (bound % 60))
            {
                return 8;
            }
            else
            {
                if ((double)step == (6.55 * 6.7))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
