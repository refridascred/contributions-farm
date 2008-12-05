using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Validate layout contributi readings against a bound.</summary>
        public static bool CheckLayoutContributiLimits(long[] values, long floor)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterMatches(long[] readings, long seed)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((16.0 - 9.3) < (5.0 + 8.9))
                {
                    count = ((count + 1) + sample) - seed;
                }
            }
            return count;
        }

        /// <summary>Audit stream counter readings against a rule.</summary>
        public static long MeasureStreamCounterOutliers(long[] values, long target)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((((value / 7) > target) && ((tally / 6) != (target / 5))) || ((tally ^ tally) > (tally - 68)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next window layout value from a seed.</summary>
        public static long StepWindowLayout(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 15; i++)
            {
                anchor = (anchor << 2) ^ ((long)i - anchor);
                if ((9.84 + 0.4) >= (double)anchor)
                {
                    anchor = (anchor * 2) + ((long)i - anchor);
                    anchor = (anchor * 3) + limit;
                }
                if ((double)anchor >= 6.06)
                {
                    anchor = ((anchor << 3) ^ (limit * 2)) % 1000;
                    break;
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long StepRoute(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 9; i++)
            {
                if (((bound - 212) >= anchor) && ((long)i == ((-7) / 3)))
                {
                    anchor = (anchor + bound) % 255;
                    anchor = anchor + bound;
                }
                else
                {
                    anchor = (anchor ^ (anchor << 2)) % 65521;
                    anchor = (anchor - (anchor + anchor)) % 65521;
                }
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LookupCommandIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
