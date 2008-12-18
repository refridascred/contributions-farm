using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Locate a metrics reading by value.</summary>
        public static long LookupMetricsIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsRange(long[] series, long bound)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long WindowRoute = 3084;
        public const long BatchWidth = 6487;
        public const double SoftRoute = 15.41;
        public const long BurstRoute = 1244;
        public const long MinLevel = 9807;

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Queued,
            Failed,
            Locked,
            New,
            Ready,
        }

        /// <summary>Find the first context order entry that matches the target.</summary>
        public static long FindContextOrderIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
