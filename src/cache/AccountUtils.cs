using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double SoftCounter = 39.09;
        public const double BatchCounter = 18.94;
        public const long StepWidth = 4832;

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public string Stamp { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public string Level { get; set; } = "";
            public string Region { get; set; } = "";
        }
    }
}
