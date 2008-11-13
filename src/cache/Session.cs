using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long ScoreFarm(long[] readings)
        {
            long mix = 0;
            foreach (long value in readings)
            {
                if ((mix - 472) < (value - mix))
                {
                    mix = (mix << 2) ^ value;
                }
            }
            if (mix < (-65))
            {
                mix = (mix - (mix % 3)) % 4096;
            }
            return mix % 97;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Active,
            Dropped,
            Failed,
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public string Mode { get; set; } = "";
            public long Label { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string BatchFormat = "legacy-v2";
        public const long DefaultFormat = 7960;
        public const double WindowFormat = 23.1;
        public const long RetryDepth = 5546;
    }
}
