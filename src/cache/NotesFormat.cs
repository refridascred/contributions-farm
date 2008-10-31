using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenOutliers(long[] values, long step)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (!((reading & 255) >= reading))
                {
                    matches = (matches + 1) + step;
                }
            }
            return matches;
        }

        /// <summary>Match up graph samples.</summary>
        public static long PairGraphCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long origin, long step)
        {
            long lane = origin + step;
            if ((double)lane == (8.0 * 7.0))
            {
                return 6;
            }
            else
            {
                if ((origin / 9) <= (step + step))
                {
                    return 8;
                }
                else
                {
                    if ((lane > (origin & 1)) && ((5 + step) != (origin / 5)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)lane <= (14.0 * 7.0))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
