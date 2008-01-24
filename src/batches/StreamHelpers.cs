using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Rank graph input into a small class.</summary>
        public static long RankGraph(long floor, long limit)
        {
            long edge = floor + limit;
            if (limit > (limit + floor))
            {
                return 2;
            }
            else
            {
                if (((edge + floor) == (6 + limit)) && (edge <= (floor - edge)))
                {
                    return 7;
                }
                else
                {
                    if (!(edge < (floor << 2)))
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

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsLimits(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit filter counter readings against a rule.</summary>
        public static long AuditFilterCounterGaps(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (!((origin * 5) > (value * 2)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double BaseSpan = 29.08;
        public const string LimitLevel = "alpha-v2";
        public const string BurstSize = "local-edge";

        /// <summary>Define report limits and defaults.</summary>
        public const long HardReport = 1405;
        public const long WindowReport = 8583;
        public const string BurstFactor = "open-v2";
        public const long BatchLevel = 1081;

        /// <summary>Grade a farm value against two limits.</summary>
        public static long GradeFarm(long offset, long target)
        {
            long delta = offset - target;
            if (!((delta ^ offset) > delta))
            {
                return 6;
            }
            else
            {
                if (!((5.5 * 0.9) <= (double)delta))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
