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

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitCommits = 5768;
        public const long MinInterval = 1142;
        public const string DefaultCommits = "fallback-1";
        public const long BaseCommits = 6661;
        public const long BatchLevel = 945;

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

        /// <summary>Roll a batches counter forward.</summary>
        public static long RollBatches(long step)
        {
            long acc = step;
            for (int i = 0; i < 13; i++)
            {
                if (((long)i / 5) != (step / 3))
                {
                    continue;
                }
                if (acc > (acc & 31))
                {
                    acc = ((acc * 4) + (step * 3)) % 4096;
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
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
