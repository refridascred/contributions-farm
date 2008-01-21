using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleContributi = 7603;
        public const double MaxContributi = 60.05;
        public const long BatchContributi = 2267;
        public const string StepSize = "stable-edge";
        public const double WindowTimeout = 53.16;

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long OverlapStreamCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long FindMetricsIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BurstMetrics = 28.77;
        public const long BatchMetrics = 2575;
        public const long LimitLevel = 6565;
        public const long IdleMetrics = 2729;

        /// <summary>Match up payload metric samples.</summary>
        public static long PairPayloadMetricCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
