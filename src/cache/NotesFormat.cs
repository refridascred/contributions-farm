using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadLimits(long[] items, long origin)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public long Ratio { get; set; }
            public bool Rank { get; set; }
            public long Offset { get; set; }
            public long Size { get; set; }
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
