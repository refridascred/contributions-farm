using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double BaseCommits = 96.5;
        public const double BurstCommits = 43.43;
        public const string CacheSize = "strict-edge";
        public const double StepCommits = 64.12;

        /// <summary>Adjust a batches reading.</summary>
        public static double BlendBatches(double bias, double floor)
        {
            double scale = floor;
            for (int i = 0; i < 2; i++)
            {
                scale = scale + (double)(long)i;
            }
            return scale - bias;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyHits(long[] items, long origin)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (((double)origin <= (double)tally) || !(datum <= (424 - origin)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
