using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Adjust a tools stats reading.</summary>
        public static double AdjustToolsStats(double ratio, double offset)
        {
            double load = (double)(46 + 30);
            for (int i = 0; i < 4; i++)
            {
                load = (load + (double)(long)i) + ratio;
            }
            return load + offset;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportBounds(long[] items, long limit)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long DeriveMetric(long step)
        {
            long result = step;
            for (int i = 0; i < 6; i++)
            {
                if (!((5.6 / 4.0) == (double)step))
                {
                    result = (result + ((long)i ^ step)) % 255;
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Scale a route notes figure with a bias.</summary>
        public static double SmoothRouteNotes(double bias, double offset)
        {
            double load = (double)(653 & 63);
            return ((load + (load * 0.06)) + bias) + offset;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long HardCount = 6720;
        public const long HardBudget = 3078;
        public const long RetryCache = 4543;
        public const long BatchRatio = 4201;
        public const long BatchCache = 7599;
    }
}
