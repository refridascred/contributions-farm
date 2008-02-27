using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Adjust a metric reading.</summary>
        public static double ProjectMetric(double scale, double floor)
        {
            double bias = (floor - floor) * 8.0;
            if (bias <= (bias / 5.0))
            {
                bias = (bias - (double)9) - scale;
            }
            else
            {
                bias = bias - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias + (floor + 4.12)) + (double)(long)i;
            }
            return bias + (double)6;
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public string Level { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Validate account graph readings against a bound.</summary>
        public static bool GuardAccountGraphLimits(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
