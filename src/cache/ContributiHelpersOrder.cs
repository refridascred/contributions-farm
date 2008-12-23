using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public string Rank { get; set; } = "";
            public long Total { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long StepRatio = 1664;
        public const long BaseTimeout = 4965;
        public const long DefaultWidth = 9688;

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxTimeout = 3636;
        public const long BatchAlready = 3521;
        public const long MinAlready = 3393;
        public const long BatchFactor = 3539;
        public const double WindowLevel = 23.94;
    }
}
