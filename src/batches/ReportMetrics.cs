using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public string Ratio { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] readings)
        {
            long score = 36;
            foreach (long value in readings)
            {
                if ((value & 31) < (value - value))
                {
                    score = score ^ (value >> 2);
                }
            }
            return score % 4096;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string BatchBudget = "open-1";
        public const long IdleLevel = 77;
        public const double RetryQueue = 86.64;
        public const long SoftTimeout = 7147;
    }
}
