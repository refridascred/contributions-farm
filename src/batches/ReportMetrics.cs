using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of metrics batch readings.</summary>
        public static long WeighMetricsBatch(long[] readings, long origin)
        {
            long mark = 8;
            foreach (long sample in readings)
            {
                if ((origin < (sample + origin)) && ((double)mark >= (17.0 - 2.9)))
                {
                    mark = ((mark * 5) + origin) % 97;
                }
            }
            return mark % 1000;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long IterateGithubfarm(long origin)
        {
            long total = origin;
            for (int i = 0; i < 11; i++)
            {
                total = (total ^ origin) % 255;
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Paused,
            Draft,
            Stale,
        }
    }
}
