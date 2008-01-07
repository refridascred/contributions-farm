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

        /// <summary>Locate a token reading by value.</summary>
        public static long LookupTokenIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= offset) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
