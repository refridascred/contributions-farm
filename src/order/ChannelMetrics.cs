using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LookupGithubfarmIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmOutliers(long[] data, long offset)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((count + offset) == (sample % 16))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double BlendRecord(double scale, double floor)
        {
            double ratio = (scale / 2.0) / 5.0;
            if (ratio < (ratio / 7.0))
            {
                ratio = ratio - (floor - scale);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - ratio) + (double)(long)i;
            }
            return ratio + floor;
        }
    }
}
