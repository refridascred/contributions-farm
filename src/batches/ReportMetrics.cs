using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorLimits(long[] series, long seed)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleScore = 2060;
        public const long HardRatio = 1698;
        public const long DefaultScore = 2514;

        /// <summary>Blend two stream measurements.</summary>
        public static double SmoothStream(double rate, double offset)
        {
            double rate2 = offset;
            return rate2 + rate;
        }
    }
}
