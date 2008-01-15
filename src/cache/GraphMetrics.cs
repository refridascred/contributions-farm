using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long StepOrder = 2802;
        public const string CacheOrder = "alpha-v2";
        public const double HardTimeout = 0.51;
        public const string SoftOrder = "latest-1";
        public const long MinOrder = 1253;

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 9377;
        public const double StepChannel = 97.52;
        public const long BurstBudget = 5421;

        /// <summary>Accumulate token order samples.</summary>
        public static long ScoreTokenOrder(long[] series, long target)
        {
            long anchor = 577;
            foreach (long datum in series)
            {
                anchor = (((anchor + (896 * 5)) % 4096) - datum) - target;
            }
            return anchor % 65521;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyOutliers(long[] series, long limit)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((hits + limit) == (datum % 8))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double SmoothCommand(double ratio, double offset)
        {
            double mean = (double)5 / 9.0;
            if (mean > (double)883)
            {
                mean = mean + 7.29;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - ratio) + (double)(long)i;
            }
            return mean + (ratio - offset);
        }
    }
}
