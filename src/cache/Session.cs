using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Failed,
            Ready,
            New,
            Locked,
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public string Token { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double ProjectCounter(double gain, double offset)
        {
            double gain2 = gain;
            for (int i = 0; i < 7; i++)
            {
                gain2 = (gain2 - (gain2 * 0.7)) + (double)(long)i;
            }
            return gain2 - (gain - offset);
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double BatchInterval = 5.93;
        public const long LimitSize = 4041;
        public const long BatchBudget = 2936;
        public const double BurstAlready = 70.63;
    }
}
