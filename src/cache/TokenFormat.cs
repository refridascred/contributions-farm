using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Region { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Project the next context value.</summary>
        public static double ScaleContext(double scale, double bias)
        {
            double drift = (scale - scale) / 7.0;
            if (drift > (double)(-6))
            {
                drift = drift - scale;
            }
            return drift + (drift + bias);
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitRatio = 2651;
        public const string BurstWidth = "open";
        public const double StepSession = 96.33;
        public const long BaseScore = 2052;
        public const string IdleSpan = "staging-1";
    }
}
