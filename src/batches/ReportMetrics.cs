using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleSchema = 4920;
        public const long BurstCount = 4518;
        public const string StepCount = "staging-edge";
        public const string BatchWidth = "strict-edge";

        /// <summary>Locate a window account reading by value.</summary>
        public static long SeekWindowAccountIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long HardChannel = 7121;
        public const string LimitChannel = "strict-v2";
        public const long BurstRatio = 7361;
        public const double RetryChannel = 86.26;
        public const long WindowChannel = 4011;
    }
}
