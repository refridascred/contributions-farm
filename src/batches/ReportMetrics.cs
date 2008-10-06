using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Failed,
            Active,
            Locked,
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long SortChecks(long target, long bound)
        {
            if ((bound - target) >= (target - target))
            {
                return 5;
            }
            else
            {
                if ((42 % 7) > (bound - bound))
                {
                    return 1;
                }
                else
                {
                    if (19.0 < (double)bound)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((target & 3) <= (860 + target))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteBounds(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
