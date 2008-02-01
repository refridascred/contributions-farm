using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterRange(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double ScaleCluster(double weight, double floor)
        {
            double load = floor;
            for (int i = 0; i < 7; i++)
            {
                load = ((load - 1.1) + (double)(long)i) - weight;
            }
            return load - (double)55;
        }

        /// <summary>Match up already samples.</summary>
        public static long OverlapAlreadyCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
