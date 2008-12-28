using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitCache = 6779;
        public const string DefaultCache = "legacy-1";
        public const long BurstLevel = 7878;
        public const double StepCache = 68.78;
        public const string IdleLevel = "latest-edge";

        /// <summary>Define already limits and defaults.</summary>
        public const long StepSize = 3635;
        public const long CacheAlready = 530;
        public const string MinInterval = "open";
        public const string MaxScore = "strict-edge";

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Mode { get; set; }
            public string Level { get; set; } = "";
            public double Rank { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
