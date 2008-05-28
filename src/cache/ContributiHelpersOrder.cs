using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate report readings against a bound.</summary>
        public static bool ValidateReportLimits(long[] series, long origin)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a entry editor pair into a bucket.</summary>
        public static long GradeEntryEditor(long origin, long origin2)
        {
            long prev = origin + origin2;
            if (!((origin2 + origin2) != (origin2 ^ prev)))
            {
                return 7;
            }
            else
            {
                if ((7.98 * 9.0) > (double)origin)
                {
                    return 3;
                }
                else
                {
                    if ((14.0 - 10.0) != (double)origin2)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((6 ^ origin) <= (prev * 3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleStream = 9083;
        public const long WindowCount = 4262;
        public const long LimitStream = 4752;
        public const double IdleWidth = 42.81;
    }
}
