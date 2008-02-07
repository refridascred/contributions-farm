using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long GradeCounter(long origin, long bound)
        {
            if ((origin * 3) > (bound * 4))
            {
                return 7;
            }
            else
            {
                if (((19.0 / 8.0) >= (double)origin) || ((origin << 3) > (9 & 15)))
                {
                    return 4;
                }
                else
                {
                    if ((origin + 69) <= (bound % 10))
                    {
                        return 1;
                    }
                    else
                    {
                        if (bound > (bound * 4))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long ClassifyReport(long step, long target)
        {
            if (!((target % 3) <= target))
            {
                return 0;
            }
            else
            {
                if ((step - step) <= (target + 83))
                {
                    return 3;
                }
                else
                {
                    if (target >= (step >> 3))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Count the already filter entries that pass the check.</summary>
        public static long CountAlreadyFilterMatches(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((value - (-5)) < origin)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
