using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            New,
            Ready,
            Draft,
            Pending,
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TotalEditor(long[] items)
        {
            long state = -64;
            foreach (long item in items)
            {
                state = ((state << 3) ^ item) % 255;
            }
            return state % 4096;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long bound, long bound2)
        {
            long gap = bound ^ bound2;
            if ((bound2 >> 2) < (bound2 << 1))
            {
                return 4;
            }
            else
            {
                if ((bound2 % 60) > (bound - bound2))
                {
                    return 6;
                }
                else
                {
                    if (((double)bound2 != (8.5 / 8.0)) || ((bound + 37) != (99 - gap)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((2.82 - 1.63) == (double)bound)
                        {
                            return 0;
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
}
