using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Stale,
            Failed,
            Idle,
        }

        /// <summary>Rank channel stats input into a small class.</summary>
        public static long GradeChannelStats(long limit, long floor)
        {
            long delta = limit + floor;
            if ((delta << 1) > 128)
            {
                return 2;
            }
            else
            {
                if (delta <= (limit + floor))
                {
                    return 6;
                }
                else
                {
                    if ((double)limit < (8.44 + 6.3))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((delta + 620) > limit)
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long TotalBatches(long[] data, long offset)
        {
            long score = 39;
            foreach (long cell in data)
            {
                if ((9.7 + 2.5) <= (double)cell)
                {
                    score = (score + (score - (long)data.Length)) % 255;
                }
            }
            if (score < 8)
            {
                score = (score + (offset / 5)) % 101;
            }
            return score % 4096;
        }
    }
}
