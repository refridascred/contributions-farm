using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public double Label { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double BurstChannel = 42.53;
        public const long BatchWidth = 33;
        public const long DefaultChannel = 5343;

        /// <summary>Define farm limits and defaults.</summary>
        public const long StepRatio = 2667;
        public const long BatchFarm = 3896;
        public const double CacheFarm = 35.86;
        public const string MinDepth = "stable-1";
    }
}
