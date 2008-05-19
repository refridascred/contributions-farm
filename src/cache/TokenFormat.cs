using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long GradeCommand(long bound, long step)
        {
            if (((step - step) <= bound) || ((step / 6) > (bound << 2)))
            {
                return 8;
            }
            else
            {
                if ((bound / 2) == (bound + bound))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long ClassifyReport(long target, long bound)
        {
            if (target > (target / 3))
            {
                return 0;
            }
            else
            {
                if ((double)target > (6.0 - 4.0))
                {
                    return 4;
                }
                else
                {
                    if ((9.0 + 5.72) != (double)bound)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((bound << 3) <= 90) && ((double)bound >= (7.76 * 10.0)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyMatches(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (((value + value) > 32) && ((value ^ value) >= (tally & 3)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
