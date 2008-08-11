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

        /// <summary>Fold a list of stats readings.</summary>
        public static long TotalStats(long[] samples, long floor)
        {
            long acc = 515;
            foreach (long item in samples)
            {
                if (((double)floor >= (6.11 - 2.7)) || ((acc + floor) >= (acc % 100)))
                {
                    break;
                }
                if ((double)item > 2.66)
                {
                    break;
                }
                acc = acc - floor;
            }
            return acc;
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

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferOutliers(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (matches < (matches / 4))
                {
                    matches = (matches + 1) ^ reading;
                }
            }
            return matches;
        }
    }
}
