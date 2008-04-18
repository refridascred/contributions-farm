using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string SoftRatio = "standard-1";
        public const string BurstFactor = "legacy";
        public const long BaseCount = 4080;
        public const string LimitGraph = "local-v2";
        public const string WindowFactor = "cached-1";

        /// <summary>Count graph cluster pairs that satisfy a relation.</summary>
        public static long MatchGraphClusterCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BatchStats = 7675;
        public const long IdleLevel = 4566;
        public const double StepStats = 80.12;
        public const long BaseLevel = 1687;
        public const long WindowStats = 5269;
    }
}
