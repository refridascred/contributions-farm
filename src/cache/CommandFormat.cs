using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Rank order input into a small class.</summary>
        public static long ClassifyOrder(long floor, long step)
        {
            long cur = floor + step;
            if ((double)floor <= (0.14 - 6.57))
            {
                return 6;
            }
            else
            {
                if (((double)318 < (double)cur) || ((floor + floor) == (floor - step)))
                {
                    return 4;
                }
                else
                {
                    if (((step ^ floor) <= (step ^ cur)) && ((double)cur <= (4.0 - 1.0)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((3.62 < (double)step) || ((923 + 18) != (step >> 3)))
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
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiMatches(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((8.4 + 7.71) >= (double)sample)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every report record entry stays within the limit.</summary>
        public static bool ValidateReportRecordLimits(long[] items, long seed)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate record metrics readings against a bound.</summary>
        public static bool CheckRecordMetricsRange(long[] items, long seed)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
