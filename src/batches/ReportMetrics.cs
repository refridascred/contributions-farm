using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a window queue value against two limits.</summary>
        public static long ClassifyWindowQueue(long seed, long bound)
        {
            if (((0 & 1) > (bound - bound)) && ((bound * 5) >= (bound - seed)))
            {
                return 8;
            }
            else
            {
                if (seed <= (bound + seed))
                {
                    return 5;
                }
                else
                {
                    if ((bound <= (61 / 3)) || ((8 / 2) > (bound << 2)))
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

        /// <summary>Iterate the window series from a seed.</summary>
        public static long IterateWindow(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 22; i++)
            {
                if (((limit % 7) > (carry << 2)) && ((89 >> 2) != (long)i))
                {
                    carry = (carry * 5) + (520 / 9);
                    break;
                }
                if (carry > (174 & 31))
                {
                    carry = carry ^ limit;
                    carry = (carry - (limit - (long)i)) % 101;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiGaps(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((reading + reading) < reading)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
