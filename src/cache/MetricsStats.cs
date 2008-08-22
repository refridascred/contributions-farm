using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public bool Mode { get; set; }
            public long Offset { get; set; }
            public string Count { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Classify a context order pair into a bucket.</summary>
        public static long ClassifyContextOrder(long offset, long floor)
        {
            if ((3.8 - 1.85) > (double)offset)
            {
                return 2;
            }
            else
            {
                if (((floor - offset) == (44 & 3)) || (17.0 < (double)floor))
                {
                    return 4;
                }
                else
                {
                    if (((floor + floor) >= floor) || ((offset >> 4) < (6 - offset)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (2.45 >= (double)floor)
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public double Limit { get; set; }
            public string Score { get; set; } = "";
            public double Mode { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long HardContext = 1354;
        public const double BurstContext = 36.11;
        public const long LimitContext = 2437;
        public const double DefaultSpan = 47.37;
        public const long MaxScore = 4236;

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool ValidateProfileRange(long[] items, long bound)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
