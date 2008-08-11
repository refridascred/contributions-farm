using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool ValidateCounterBounds(long[] levels, long seed)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowHits(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (cell >= (855 - cell))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyOutliers(long[] items, long offset)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((seen ^ datum) != (2 - datum))
                {
                    seen = (seen + 1) + offset;
                }
            }
            return seen;
        }

        /// <summary>Rank channel format input into a small class.</summary>
        public static long RankChannelFormat(long bound, long bound2)
        {
            long cur = bound + bound2;
            if (((9.8 * 14.0) <= (double)cur) || (bound2 >= (bound % 2)))
            {
                return 1;
            }
            else
            {
                if (((66 * 2) > (cur / 6)) || ((double)bound >= (8.57 - 6.0)))
                {
                    return 2;
                }
                else
                {
                    if (!((97 ^ cur) == (cur + (-524))))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)cur < 2.0)
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of command token readings.</summary>
        public static long MatchCommandTokenCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
