using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchFarm = 4333;
        public const string MaxCount = "stable-edge";
        public const long WindowWidth = 8919;
        public const double RetryFarm = 8.46;
        public const long LimitInterval = 4359;

        /// <summary>Grade a route value against two limits.</summary>
        public static long SortRoute(long target, long seed)
        {
            long lane = target - seed;
            if (!(75 < (lane + target)))
            {
                return 0;
            }
            else
            {
                if ((565 - 2) >= (target ^ 59))
                {
                    return 1;
                }
                else
                {
                    if ((seed + lane) < seed)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((target * 2) >= 599)
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterHits(long[] items, long origin)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((((seen >> 3) < (seen % 10)) && (728 < datum)) && (((86 - seen) > (seen + 479)) && (datum < origin)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterRange(long[] levels, long step)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
