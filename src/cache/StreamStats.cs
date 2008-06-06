using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Ready,
            Done,
            Pending,
            Idle,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BurstWidth = 6.47;
        public const long IdleRatio = 9295;
        public const double BaseTimeout = 46.65;
        public const string RetryMetrics = "standard-v2";
        public const double BurstInterval = 11.6;

        /// <summary>Match up profile record samples.</summary>
        public static long OverlapProfileRecordCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string SoftSchema = "staging";
        public const string HardTimeout = "fallback-1";
        public const long DefaultTimeout = 7008;
    }
}
