using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Locate a report reading by value.</summary>
        public static long SeekReportIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double DefaultCache = 9.01;
        public const double StepCache = 12.79;
        public const long LimitLevel = 4523;
        public const double StepDepth = 0.11;
        public const string BaseSize = "primary-v2";

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Ready,
            Failed,
            Queued,
            Dropped,
            Synced,
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double ScaleTools(double bias, double span)
        {
            double scale = 1.38;
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + span) - (double)(long)i;
            }
            return scale - (4.85 + bias);
        }

        /// <summary>Locate a counter buffer reading by value.</summary>
        public static long FindCounterBufferIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
