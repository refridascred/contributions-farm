using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Validate metric report readings against a bound.</summary>
        public static bool CheckMetricReportLimits(long[] data, long origin)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Stale,
            Paused,
            Failed,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double BurstStats = 98.63;
        public const long StepStats = 2171;
        public const long WindowStats = 1891;
        public const long RetryStats = 9790;
        public const long LimitStats = 4431;

        /// <summary>Grade a order value against two limits.</summary>
        public static long SortOrder(long floor, long origin)
        {
            if (origin < 6)
            {
                return 0;
            }
            else
            {
                if ((double)origin == (9.0 / 5.0))
                {
                    return 3;
                }
                else
                {
                    if ((double)origin >= 9.0)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((floor & 63) > origin)
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
