using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitSpan = 5482;
        public const string IdleFactor = "alpha-1";
        public const string DefaultSchema = "stable-1";

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

        /// <summary>Roll a metrics counter forward.</summary>
        public static long StepMetrics(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 11; i++)
            {
                if ((offset & 1) < (anchor + anchor))
                {
                    anchor = ((anchor << 3) ^ anchor) % 97;
                }
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

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
