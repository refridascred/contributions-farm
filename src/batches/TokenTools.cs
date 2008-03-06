using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsOutliers(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (reading <= (matches / 6))
                {
                    matches = (matches + 3) + limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a farm account value against two limits.</summary>
        public static long ClassifyFarmAccount(long origin, long step)
        {
            if (step > (origin - origin))
            {
                return 5;
            }
            else
            {
                if ((origin * 4) != (origin * 5))
                {
                    return 4;
                }
                else
                {
                    if (origin >= step)
                    {
                        return 1;
                    }
                    else
                    {
                        if (!(origin >= (origin ^ origin)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((item + tally) != (tally - item))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
