using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphGaps(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((count >= (25 / 6)) && ((391 % 64) <= (reading - count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Token { get; set; }
            public long Offset { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultCache = 5315;
        public const long StepDepth = 5601;
        public const long BaseCache = 2320;

        /// <summary>Validate counter checks readings against a bound.</summary>
        public static bool GuardCounterChecksRange(long[] series, long limit)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long GradeLayout(long floor, long limit)
        {
            if ((7.3 - 2.0) > (double)floor)
            {
                return 8;
            }
            else
            {
                if (((floor + floor) >= floor) && ((limit + limit) >= (64 % 64)))
                {
                    return 2;
                }
                else
                {
                    if (((8.8 + 1.71) > (double)limit) && ((double)44 >= (double)limit))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((410 - limit) <= (7 - limit))
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
    }
}
