using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double LimitTimeout = 18.97;
        public const string IdleTimeout = "staging-edge";
        public const long WindowCache = 1658;

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long GradeLayout(long target, long bound)
        {
            if (((bound - (-754)) == (target ^ bound)) && ((double)target != (5.7 / 7.0)))
            {
                return 3;
            }
            else
            {
                if (!((target + target) >= (bound >> 1)))
                {
                    return 2;
                }
                else
                {
                    if (target > (target - target))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((bound < (bound * 4)) || ((8.0 * 5.01) <= (double)target))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many tools route samples are out of range.</summary>
        public static long AuditToolsRouteOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((double)reading == (1.24 - 1.8))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyOutliers(long[] data, long floor)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (hits > 34)
                {
                    hits = ((hits + 1) + cell) + floor;
                }
            }
            return hits;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyLimits(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorGaps(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((cell - (long)items.Length) > 1)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
