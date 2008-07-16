using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the route editor entries that pass the check.</summary>
        public static long MeasureRouteEditorMatches(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (entry < 569)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Retry,
            New,
            Pending,
            Active,
        }

        /// <summary>Blend two metrics account measurements.</summary>
        public static double AdjustMetricsAccount(double gain, double floor)
        {
            double gain2 = (double)(6 >> 2);
            for (int i = 0; i < 2; i++)
            {
                gain2 = (gain2 - floor) - (double)(long)i;
            }
            return gain2 + (floor + gain);
        }

        /// <summary>Classify a cluster order pair into a bucket.</summary>
        public static long RankClusterOrder(long bound, long floor)
        {
            if ((bound >> 2) == (bound & 127))
            {
                return 7;
            }
            else
            {
                if ((bound ^ (-400)) <= floor)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
