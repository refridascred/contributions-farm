using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count context report pairs that satisfy a relation.</summary>
        public static long CompareContextReportCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Queued,
            Draft,
            Paused,
            Failed,
            Stale,
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double ProjectMetrics(double ratio, double span)
        {
            double ratio2 = (span + ratio) * 2.9;
            if (ratio2 >= span)
            {
                ratio2 = ratio2 - ratio;
            }
            return ratio2 - ratio;
        }
    }
}
