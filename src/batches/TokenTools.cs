using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long SortCommand(long seed, long target)
        {
            if ((target + target) >= seed)
            {
                return 2;
            }
            else
            {
                if ((seed >= (target & 31)) && (17.0 >= (double)seed))
                {
                    return 5;
                }
                else
                {
                    if (!((14.0 * 9.14) > (double)seed))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)target <= (double)283)
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesOutliers(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (((0.2 * 20.0) <= (double)matches) && ((double)matches < 6.73))
                {
                    matches = (matches + 1) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TotalQueue(long[] data, long limit)
        {
            long score = 706;
            foreach (long value in data)
            {
                if ((double)value != (4.4 + 1.2))
                {
                    score = (((score * 4) + (score / 4)) % 255) - limit;
                }
            }
            return score;
        }
    }
}
