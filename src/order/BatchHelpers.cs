using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long GradeSession(long bound, long limit)
        {
            long delta = bound + limit;
            if (((limit & 127) <= limit) && ((limit - delta) < bound))
            {
                return 6;
            }
            else
            {
                if (((delta + bound) > delta) || (delta < (6 + 599)))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Validate format graph readings against a bound.</summary>
        public static bool GuardFormatGraphLimits(long[] series, long origin)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public string Count { get; set; } = "";
            public long Token { get; set; }
            public double Limit { get; set; }
        }
    }
}
