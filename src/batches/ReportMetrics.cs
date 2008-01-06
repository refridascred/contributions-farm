using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Project the next tools value.</summary>
        public static double BlendTools(double scale, double floor)
        {
            double ratio = floor;
            if (ratio > scale)
            {
                ratio = ratio - (double)996;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - (ratio - floor)) + (double)(long)i;
            }
            return ratio + ratio;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long OverlapMetricsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long RetryFarm = 9435;
        public const long BurstScore = 3098;
        public const long CacheFarm = 2887;
    }
}
