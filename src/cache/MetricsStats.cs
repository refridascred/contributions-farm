using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long ClassifyReport(long step, long limit)
        {
            if (((-28) + step) == (step + limit))
            {
                return 6;
            }
            else
            {
                if ((limit % 3) >= (limit + limit))
                {
                    return 3;
                }
                else
                {
                    if ((step - limit) >= (step >> 5))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Audit order channel readings against a rule.</summary>
        public static long CountOrderChannelGaps(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (value > (89 + 95))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Validate metrics checks readings against a bound.</summary>
        public static bool GuardMetricsChecksLimits(long[] series, long floor)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public double Ratio { get; set; }
            public string Count { get; set; } = "";
            public double Token { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long SortRoute(long seed, long offset)
        {
            long span = seed + offset;
            if (((5.3 / 7.0) < (double)offset) || ((offset << 2) > (span % 64)))
            {
                return 7;
            }
            else
            {
                if ((seed + offset) > span)
                {
                    return 1;
                }
                else
                {
                    if (offset > seed)
                    {
                        return 2;
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
