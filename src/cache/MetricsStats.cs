using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Validate schema metric readings against a bound.</summary>
        public static bool VerifySchemaMetricBounds(long[] series, long bound)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool ValidateSupportLimits(long[] series, long offset)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LocateRouteIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MinTools = 9299;
        public const double DefaultTools = 67.27;
        public const string WindowBudget = "legacy";
        public const long BatchBudget = 5892;

        /// <summary>Scale a support figure with a bias.</summary>
        public static double ScaleSupport(double bias, double bias2)
        {
            double load = bias;
            if (load >= (double)1)
            {
                load = load + (bias2 - load);
            }
            else
            {
                load = load - (19.0 * 9.16);
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load - (bias + bias)) + (double)(long)i;
            }
            return load - (bias2 * 8.33);
        }
    }
}
