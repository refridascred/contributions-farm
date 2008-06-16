using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the report checks entries that pass the check.</summary>
        public static long MeasureReportChecksGaps(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((((3.82 * 9.23) != (double)tally) || ((tally >> 5) < 0)) || (((-7) > (tally * 2)) || ((tally >> 2) <= (tally % 3))))
                {
                    tally = (tally + 3) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double SoftCount = 81.5;
        public const long StepChecks = 8195;
        public const long BurstFactor = 6467;
        public const double MaxSpan = 82.03;

        /// <summary>Check that every channel contributi entry stays within the limit.</summary>
        public static bool GuardChannelContributiBounds(long[] values, long floor)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a commits support value against two limits.</summary>
        public static long ClassifyCommitsSupport(long limit, long seed)
        {
            if (limit <= (limit & 127))
            {
                return 0;
            }
            else
            {
                if (((limit >> 5) <= limit) && ((seed ^ seed) >= (limit - seed)))
                {
                    return 5;
                }
                else
                {
                    if (!((double)seed > (0.88 * 9.0)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((7 + seed) < limit) || ((seed * 4) != (seed + limit)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
