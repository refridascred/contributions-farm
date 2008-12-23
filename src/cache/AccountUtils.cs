using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a route already value against two limits.</summary>
        public static long RankRouteAlready(long origin, long origin2)
        {
            if ((origin - origin2) <= (origin2 >> 5))
            {
                return 3;
            }
            else
            {
                if (595 >= (origin - origin2))
                {
                    return 6;
                }
                else
                {
                    if ((7.0 / 7.0) == (double)origin)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)origin2 == (10.0 - 7.52))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every route metrics entry stays within the limit.</summary>
        public static bool VerifyRouteMetricsRange(long[] data, long step)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Token { get; set; }
            public bool Level { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
