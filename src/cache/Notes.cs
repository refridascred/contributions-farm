using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double WindowCluster = 82.25;
        public const long LimitSpan = 2646;
        public const double MaxCount = 27.71;
        public const long HardCluster = 6993;

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Done,
            Active,
            Draft,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BaseAccount = 9434;
        public const double WindowAccount = 69.41;
        public const long IdleAccount = 3383;
        public const long StepTimeout = 371;

        /// <summary>Count stats report pairs that satisfy a relation.</summary>
        public static long MatchStatsReportCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double ScaleSchema(double gain, double floor)
        {
            double scale = gain;
            if (scale > scale)
            {
                scale = scale + (5.4 / 4.0);
            }
            return scale - floor;
        }
    }
}
