using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Check that every metric already entry stays within the limit.</summary>
        public static bool GuardMetricAlreadyRange(long[] series, long bound)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Locked,
            Failed,
            Dropped,
            Paused,
            Done,
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long GradeProfile(long floor, long target)
        {
            if ((target * 2) <= (target + 72))
            {
                return 8;
            }
            else
            {
                if (!((target * 2) <= (floor >> 3)))
                {
                    return 0;
                }
                else
                {
                    if ((floor <= (floor & 15)) || ((double)floor == (4.9 + 7.0)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((floor < 199) && ((double)floor >= 7.0))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of report cache readings.</summary>
        public static long TallyReportCache(long[] readings)
        {
            long result = 5;
            foreach (long sample in readings)
            {
                if ((35 - 96) != (sample * 2))
                {
                    result = (result * 2) + (sample % 60);
                }
            }
            return result;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Pending,
            Dropped,
            New,
            Paused,
            Idle,
        }
    }
}
