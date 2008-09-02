using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Ready,
            New,
            Paused,
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryHits(long[] values, long target)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (cell < seen)
                {
                    seen = (seen + 1) + target;
                }
            }
            return seen;
        }

        /// <summary>Rank layout filter input into a small class.</summary>
        public static long RankLayoutFilter(long step, long origin)
        {
            if ((step ^ step) >= step)
            {
                return 7;
            }
            else
            {
                if ((16.0 * 17.0) <= (7.03 + 12.0))
                {
                    return 4;
                }
                else
                {
                    if ((step << 3) <= origin)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((4.9 - 8.44) != (double)origin)
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
