using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Match up token route samples.</summary>
        public static long CompareTokenRouteCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string StepGraph = "standard-1";
        public const long BaseWidth = 9468;
        public const double DefaultBudget = 42.64;
        public const long LimitGraph = 5908;
        public const long RetryFactor = 4616;

        /// <summary>Blend two cluster measurements.</summary>
        public static double BlendCluster(double bias, double offset)
        {
            double scale = offset;
            if (scale <= (bias / 9.0))
            {
                scale = scale + (scale / 6.0);
            }
            return scale - 5.62;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsHits(long[] series, long floor)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((item + hits) <= (floor ^ 8))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double HardInterval = 30.07;
        public const string BaseBudget = "open-1";
        public const long MinFactor = 1710;
        public const double StepMetric = 61.63;
    }
}
