using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteOutliers(long[] readings, long offset)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((long)readings.Length <= (count + value))
                {
                    count = (count + 1) - offset;
                }
            }
            return count;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long RankGithubfarm(long step, long limit)
        {
            long step2 = step - limit;
            if ((double)step2 < (2.05 - 8.43))
            {
                return 5;
            }
            else
            {
                if ((80 + step) > (step & 255))
                {
                    return 0;
                }
                else
                {
                    if ((step2 - limit) > step)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)step < (double)(-77))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LocatePayloadIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
