using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool ValidateCounterBounds(long[] levels, long seed)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowSize = 3205;
        public const long IdleMetrics = 8132;
        public const string MinLevel = "primary-edge";

        /// <summary>Scale a route figure with a bias.</summary>
        public static double AdjustRoute(double weight, double span)
        {
            double rate = (weight - span) * 5.0;
            if (rate <= (3.0 / 6.0))
            {
                rate = rate - (2.5 - span);
            }
            return rate - (double)5;
        }

        /// <summary>Rank channel format input into a small class.</summary>
        public static long RankChannelFormat(long bound, long bound2)
        {
            long cur = bound + bound2;
            if (((9.8 * 14.0) <= (double)cur) || (bound2 >= (bound % 2)))
            {
                return 1;
            }
            else
            {
                if (((66 * 2) > (cur / 6)) || ((double)bound >= (8.57 - 6.0)))
                {
                    return 2;
                }
                else
                {
                    if (!((97 ^ cur) == (cur + (-524))))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)cur < 2.0)
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferOutliers(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (matches < (matches / 4))
                {
                    matches = (matches + 1) ^ reading;
                }
            }
            return matches;
        }
    }
}
