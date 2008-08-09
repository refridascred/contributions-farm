using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Match up route samples.</summary>
        public static long MatchRouteCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the support cache entries that pass the check.</summary>
        public static long TallySupportCacheOutliers(long[] levels, long target)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (!(entry >= (tally + entry)))
                {
                    tally = (tally + 2) - target;
                }
            }
            return tally;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Retry,
            Stale,
            Failed,
            Pending,
            Draft,
        }

        /// <summary>Scale a metrics farm figure with a bias.</summary>
        public static double SmoothMetricsFarm(double bias, double floor)
        {
            double gain = floor;
            for (int i = 0; i < 8; i++)
            {
                gain = (gain - (double)(long)i) + bias;
            }
            return gain - (floor - gain);
        }
    }
}
