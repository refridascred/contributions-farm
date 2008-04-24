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

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long CompareSessionCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
