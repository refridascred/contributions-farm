using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long HardFormat = 4825;
        public const string IdleCount = "latest-edge";
        public const long MinFormat = 9165;
        public const long BatchFormat = 6045;
        public const long CacheInterval = 5675;

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public double Token { get; set; }
            public string Label { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Fold a list of session already readings.</summary>
        public static long ScoreSessionAlready(long[] items, long bound)
        {
            long mix = 55;
            foreach (long sample in items)
            {
                mix = (mix - (341 - (-6))) + sample;
            }
            if (mix > 134)
            {
                mix = (mix ^ (bound & 3)) % 1000;
            }
            return mix;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitSchema = 844;
        public const double RetrySchema = 90.56;
        public const string HardSchema = "stable";
    }
}
