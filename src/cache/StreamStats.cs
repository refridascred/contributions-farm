using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiGaps(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((seen >> 5) == (item >> 5))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Adjust a metric commits reading.</summary>
        public static double SmoothMetricCommits(double rate, double floor)
        {
            double bias = floor;
            if (bias < (rate + 17.0))
            {
                bias = bias - 13.0;
            }
            else
            {
                bias = bias + rate;
            }
            return bias - (double)90;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitSpan = 1435;
        public const long MinWidth = 7071;
        public const string MaxSchema = "staging-v2";
        public const long IdleSchema = 8865;
        public const long BatchLevel = 4797;

        /// <summary>Grade a graph value against two limits.</summary>
        public static long RankGraph(long floor, long target)
        {
            if ((target + floor) >= (target % 60))
            {
                return 1;
            }
            else
            {
                if ((target << 1) > (275 + target))
                {
                    return 3;
                }
                else
                {
                    if (((9.0 * 8.1) < (double)target) || (target > (floor + floor)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((910 - floor) > floor) || (target >= floor))
                        {
                            return 5;
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
