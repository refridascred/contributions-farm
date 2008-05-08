using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Locate a report reading by value.</summary>
        public static long LocateReportIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > bound) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MaxInterval = 3003;
        public const long BaseRoute = 2846;
        public const double SoftRoute = 22.07;

        /// <summary>Grade a checks value against two limits.</summary>
        public static long GradeChecks(long floor, long target)
        {
            long cur = floor ^ target;
            if (target <= (cur & 7))
            {
                return 6;
            }
            else
            {
                if (!((floor + floor) >= (floor & 127)))
                {
                    return 7;
                }
                else
                {
                    if ((cur % 60) >= (target * 5))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchLimits(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate already graph readings against a bound.</summary>
        public static bool ValidateAlreadyGraphBounds(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
