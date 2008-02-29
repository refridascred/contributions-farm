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

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Done,
            Failed,
            New,
        }

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
