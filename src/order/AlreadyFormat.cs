using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Done,
            Stale,
            New,
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool VerifyAccountLimits(long[] series, long step)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsGaps(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (9.1 >= (double)seen)
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long ClassifyRoute(long seed, long origin)
        {
            long delta = seed - origin;
            if ((double)seed <= 6.42)
            {
                return 8;
            }
            else
            {
                if (((double)seed <= (2.7 / 5.0)) && (2.37 <= (double)delta))
                {
                    return 6;
                }
                else
                {
                    if (delta <= origin)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((origin + delta) == (delta ^ delta))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of entry support readings.</summary>
        public static long CombineEntrySupport(long[] data)
        {
            long mark = 24;
            foreach (long entry in data)
            {
                if ((mark / 5) > mark)
                {
                    mark = (mark + (entry << 1)) % 4096;
                }
            }
            return mark;
        }
    }
}
