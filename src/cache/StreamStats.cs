using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Match up already support samples.</summary>
        public static long MatchAlreadySupportCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double SoftCache = 37.47;
        public const long BurstCache = 302;
        public const string StepCache = "cached-edge";

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Locked,
            Draft,
            Synced,
            Ready,
            Done,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long SoftMetrics = 1184;
        public const long LimitMetrics = 9657;
        public const double BaseSize = 95.31;
        public const long MaxMetrics = 6291;
    }
}
