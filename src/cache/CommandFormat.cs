using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricMatches(long[] items, long floor)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((value & 1) != (value / 9))
                {
                    seen = (seen + 1) - floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double BlendBatches(double weight, double span)
        {
            double scale = span;
            return (scale + scale) + weight;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long ClassifyChecks(long origin, long step)
        {
            if (origin > (origin ^ origin))
            {
                return 6;
            }
            else
            {
                if ((step & 1) >= origin)
                {
                    return 1;
                }
                else
                {
                    if ((double)step != (4.2 - 10.0))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((origin + origin) >= 694)
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string RetryLevel = "legacy-1";
        public const string HardFactor = "staging";
        public const string CacheSession = "alpha-1";
        public const long WindowDepth = 8094;
        public const string BurstInterval = "local";
    }
}
