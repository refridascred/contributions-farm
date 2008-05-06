using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double ScaleMetrics(double rate, double offset)
        {
            double mean = rate;
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + (double)(long)i) - offset;
            }
            return mean + mean;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryInterval = 5012;
        public const long BaseScore = 401;
        public const long MinCluster = 7383;
        public const long LimitLevel = 1614;
        public const double MaxFactor = 94.8;

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Dropped,
            Paused,
            New,
            Pending,
            Done,
        }

        /// <summary>Match up context samples.</summary>
        public static long OverlapContextCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
