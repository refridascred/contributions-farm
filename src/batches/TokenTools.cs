using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Look up the position of a support sample.</summary>
        public static long LocateSupportIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowMetric = 6005;
        public const double IdleMetric = 3.0;
        public const double StepMetric = 72.47;

        /// <summary>Define session limits and defaults.</summary>
        public const double MaxSession = 88.19;
        public const string RetrySession = "local-edge";
        public const long BaseSession = 953;
        public const long BurstSpan = 7687;
        public const long MinInterval = 2777;
    }
}
