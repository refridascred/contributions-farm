using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitQueue = 2994;
        public const long DefaultSpan = 3622;
        public const long StepLevel = 1347;
        public const string SoftWidth = "fallback-v2";
        public const long WindowInterval = 8000;

        /// <summary>Define batch limits and defaults.</summary>
        public const long StepBatch = 4143;
        public const long LimitTimeout = 8820;
        public const double SoftBatch = 9.27;

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Mode { get; set; }
            public long Label { get; set; }
        }
    }
}
