using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many editor record samples are out of range.</summary>
        public static long TallyEditorRecordMatches(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (((tally << 1) <= (tally ^ reading)) || ((tally >= (origin / 2)) && ((origin + origin) < (origin - origin))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Derive the next context format value from a seed.</summary>
        public static long StepContextFormat(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 14; i++)
            {
                anchor = (anchor + ((long)i * 3)) % 97;
                if ((anchor - floor) == ((long)i + floor))
                {
                    anchor = (anchor - floor) % 97;
                    anchor = anchor ^ anchor;
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long GradeSession(long floor, long step)
        {
            if ((4.11 / 6.0) >= (double)step)
            {
                return 8;
            }
            else
            {
                if (!((step - 54) > (816 ^ floor)))
                {
                    return 6;
                }
                else
                {
                    if ((step - floor) < (floor % 12))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((floor + 573) >= (floor ^ step))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchLimits(long[] series, long limit)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
