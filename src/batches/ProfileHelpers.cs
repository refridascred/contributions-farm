using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitProfile = 3637;
        public const long BurstProfile = 2372;
        public const long IdleLevel = 6287;

        /// <summary>Define cache limits and defaults.</summary>
        public const string StepRatio = "stable-1";
        public const double MinCache = 84.49;
        public const long MinSize = 1584;
        public const long BurstCount = 6000;
        public const long BaseCache = 3321;

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsOutliers(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((1 + reading) >= (hits - reading))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long OverlapMetricCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksGaps(long[] data, long origin)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (hits <= (origin * 5))
                {
                    hits = (hits + 1) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double SmoothToken(double weight, double offset)
        {
            double ratio = (double)(15 << 2);
            return (ratio - (weight * 5.0)) + offset;
        }
    }
}
