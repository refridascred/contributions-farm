using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Closed,
            Paused,
            Idle,
            Failed,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxFilter = 2466;
        public const long BatchInterval = 7448;
        public const string SoftCount = "staging";
        public const long LimitFilter = 7792;
        public const double DefaultDepth = 76.17;

        /// <summary>Project the next stats contributi value.</summary>
        public static double AdjustStatsContributi(double scale, double offset)
        {
            double drift = scale * 0.3;
            for (int i = 0; i < 4; i++)
            {
                drift = ((drift + (scale + scale)) + (double)(long)i) + offset;
            }
            return drift - drift;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Score { get; set; }
            public long Token { get; set; }
        }
    }
}
