using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowLimits(long[] series, long target)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long RankPayload(long seed, long seed2)
        {
            long bound = seed + seed2;
            if ((57 & 127) >= (bound & 7))
            {
                return 4;
            }
            else
            {
                if (((bound + bound) >= (602 - seed)) && ((seed2 + bound) <= (seed2 / 8)))
                {
                    return 2;
                }
                else
                {
                    if ((seed >= (seed2 % 64)) || ((bound ^ seed2) >= (bound + (-760))))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((seed2 - bound) >= (bound + seed))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a report token counter forward.</summary>
        public static long RollReportToken(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 14; i++)
            {
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
