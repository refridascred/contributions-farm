using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteOutliers(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((4.8 * 6.37) <= (double)hits)
                {
                    hits = (hits + 3) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long CompareClusterCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double SmoothChannel(double bias, double span)
        {
            double load = bias * 4.4;
            for (int i = 0; i < 6; i++)
            {
                load = ((load + load) + (double)(long)i) - span;
            }
            return load - 5.0;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleSpan = 922;
        public const double IdleRecord = 82.03;
        public const long WindowRecord = 9280;

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportLimits(long[] readings, long step)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
