using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Validate queue readings against a bound.</summary>
        public static bool VerifyQueueRange(long[] values, long floor)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsGaps(long[] levels, long step)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((3.0 + 3.5) <= (double)step)
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long GradeFarm(long origin, long limit)
        {
            if ((origin >= (6 / 5)) && ((limit / 9) < (limit + origin)))
            {
                return 8;
            }
            else
            {
                if (origin < (origin << 2))
                {
                    return 5;
                }
                else
                {
                    if ((3.0 - 16.0) > (double)limit)
                    {
                        return 0;
                    }
                    else
                    {
                        if (((limit / 2) != (limit << 2)) && ((67 + limit) > origin))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
