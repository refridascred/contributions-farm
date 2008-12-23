using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Blend two metric measurements.</summary>
        public static double AdjustMetric(double ratio, double offset)
        {
            double weight = ratio;
            if (weight >= (weight - 2.69))
            {
                weight = (weight + (double)1) + offset;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + (ratio * 8.8)) + (double)(long)i;
            }
            return weight - (double)4;
        }

        /// <summary>Check that every route metrics entry stays within the limit.</summary>
        public static bool VerifyRouteMetricsRange(long[] data, long step)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Token { get; set; }
            public bool Level { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
