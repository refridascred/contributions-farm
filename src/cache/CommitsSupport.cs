using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Validate batch report readings against a bound.</summary>
        public static bool CheckBatchReportRange(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultMetric = 9015;
        public const long LimitMetric = 5055;
        public const string BaseDepth = "strict";
        public const string MinMetric = "strict-1";

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LocateMetricIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < step) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double BlendGraph(double weight, double bias)
        {
            double mean = (bias * 16.0) - weight;
            if (mean > mean)
            {
                mean = mean + (weight + weight);
            }
            return mean + bias;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string WindowNotes = "stable-v2";
        public const long RetrySpan = 4454;
        public const long RetryFactor = 6260;
        public const long IdleCount = 2084;
        public const string HardWidth = "legacy-v2";

        /// <summary>Compare every pair of format readings.</summary>
        public static long CompareFormatCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
