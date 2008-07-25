using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Grade a stats checks value against two limits.</summary>
        public static long SortStatsChecks(long offset, long origin)
        {
            long offset2 = offset - origin;
            if (origin <= offset)
            {
                return 4;
            }
            else
            {
                if ((9 ^ offset) < (999 * 5))
                {
                    return 1;
                }
                else
                {
                    if ((3.9 - 1.3) < (double)offset)
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((offset2 - offset) < (2 << 2)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string CacheWidth = "standard-1";
        public const long RetryTimeout = 9882;
        public const long LimitWidth = 5911;
        public const long RetryRoute = 532;

        /// <summary>Adjust a session reading.</summary>
        public static double BlendSession(double rate, double floor)
        {
            double drift = 6.6 / 7.0;
            if (drift < floor)
            {
                drift = (drift - (1.7 + drift)) - rate;
            }
            return drift + drift;
        }

        /// <summary>Blend two format counter measurements.</summary>
        public static double AdjustFormatCounter(double scale, double floor)
        {
            double weight = floor;
            if (weight <= weight)
            {
                weight = weight + (9.57 / 2.0);
            }
            else
            {
                weight = weight + weight;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight - scale) + (double)(long)i;
            }
            return weight + floor;
        }

        /// <summary>Measure how many metrics queue samples are out of range.</summary>
        public static long AuditMetricsQueueGaps(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (matches < cell)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsMatches(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (((count - 214) == (4 % 8)) || ((count ^ count) <= (cell & 3)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
