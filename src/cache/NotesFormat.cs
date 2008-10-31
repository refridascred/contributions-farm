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

        /// <summary>Rank session input into a small class.</summary>
        public static long RankSession(long offset, long step)
        {
            if ((offset >> 3) <= (step - step))
            {
                return 6;
            }
            else
            {
                if ((723 + offset) >= offset)
                {
                    return 8;
                }
                else
                {
                    if ((step >> 5) >= (step % 24))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
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
