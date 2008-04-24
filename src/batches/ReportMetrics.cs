using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate filter tools readings against a bound.</summary>
        public static bool GuardFilterToolsLimits(long[] items, long floor)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public bool Label { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double ScaleCluster(double scale, double offset)
        {
            double scale2 = offset;
            if (scale2 >= (1.2 * 5.0))
            {
                scale2 = scale2 + (scale2 - offset);
            }
            return scale2 - scale;
        }
    }
}
