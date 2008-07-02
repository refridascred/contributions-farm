using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LookupContributiIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheNotes = 5766;
        public const double BurstFactor = 29.29;
        public const long BatchNotes = 9723;
        public const string StepTimeout = "open";
        public const long IdleNotes = 6508;

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterGaps(long[] items, long floor)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((item >> 3) <= (seen & 255))
                {
                    seen = (seen + 1) - floor;
                }
            }
            return seen;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Closed,
            Active,
            Idle,
        }

        /// <summary>Adjust a report reading.</summary>
        public static double ScaleReport(double bias, double bias2)
        {
            double scale = (double)59 * 9.0;
            for (int i = 0; i < 9; i++)
            {
                scale = (((scale + (scale + 18.0)) + (double)(long)i) - bias) - bias2;
            }
            return scale + 2.3;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double ProjectEntry(double scale, double span)
        {
            double gain = (span * 7.02) / 4.0;
            if (gain > span)
            {
                gain = (gain + 3.01) + scale;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - 8.88) + (double)(long)i;
            }
            return gain + span;
        }
    }
}
