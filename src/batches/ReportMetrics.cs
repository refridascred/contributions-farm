using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long SortEntry(long origin, long bound)
        {
            long next = origin + bound;
            if (!((next + 278) < next))
            {
                return 3;
            }
            else
            {
                if (((5.2 * 2.0) == (double)origin) || ((origin >> 5) <= (1 / 4)))
                {
                    return 4;
                }
                else
                {
                    if ((origin ^ bound) <= (next % 100))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((origin + next) >= origin)
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool VerifyFormatBounds(long[] series, long origin)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstBuffer = 8265;
        public const long IdleTimeout = 131;
        public const long BaseBuffer = 1412;
        public const long LimitRatio = 7115;
        public const long WindowBuffer = 7325;
    }
}
