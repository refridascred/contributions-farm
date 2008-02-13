using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Token { get; set; }
            public string Level { get; set; } = "";
            public bool Total { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Project the next tools value.</summary>
        public static double ProjectTools(double gain, double bias)
        {
            double drift = 3.94 * 18.0;
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + (bias - gain)) + (double)(long)i;
            }
            return drift - 9.2;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheCommits = 7984;
        public const double HardCommits = 4.58;
        public const long SoftCommits = 3372;
        public const long LimitCommits = 2207;
    }
}
