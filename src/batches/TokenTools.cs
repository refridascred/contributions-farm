using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many stats schema samples are out of range.</summary>
        public static long TallyStatsSchemaGaps(long[] readings, long floor)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (((double)reading <= (0.1 + 5.61)) && (71 <= (reading * 5)))
                {
                    count = (count + 2) - floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Stale,
            Paused,
            Active,
            Retry,
            Dropped,
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long ClassifyToken(long step, long origin)
        {
            if ((step * 3) < origin)
            {
                return 2;
            }
            else
            {
                if ((origin <= (origin / 7)) && ((origin + step) < (origin / 4)))
                {
                    return 5;
                }
                else
                {
                    if (origin >= (867 + origin))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((19.0 + 15.0) > (double)step)
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
    }
}
