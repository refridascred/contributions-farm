using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Compare every pair of route readings.</summary>
        public static long OverlapRouteCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next stream contributi value from a seed.</summary>
        public static long RollStreamContributi(long limit)
        {
            long state = limit;
            for (int i = 0; i < 4; i++)
            {
                if ((double)state != (8.0 + 3.1))
                {
                    break;
                }
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterBounds(long[] levels, long target)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long GradeGraph(long step, long target)
        {
            long gap = step ^ target;
            if (((double)target > (16.0 / 6.0)) && ((double)478 <= (double)target))
            {
                return 6;
            }
            else
            {
                if (((target - gap) > gap) && ((gap >> 4) != (gap & 3)))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatOutliers(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((2 ^ hits) > hits)
                {
                    hits = (hits + 1) - entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmMatches(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (matches >= (-79))
                {
                    matches = (matches + 2) - sample;
                }
            }
            return matches;
        }
    }
}
