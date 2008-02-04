using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public bool Mode { get; set; }
            public string Token { get; set; } = "";
            public long Total { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BaseSpan = 86.78;
        public const long StepSize = 6188;
        public const long BurstScore = 8572;
        public const long MinDepth = 2483;

        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheSpan = 5147;
        public const string WindowFilter = "primary-v2";
        public const long HardLevel = 9703;
    }
}
