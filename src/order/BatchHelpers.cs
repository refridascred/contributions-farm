using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Weight { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long CacheSupport = 3172;
        public const long IdleSupport = 8827;
        public const long LimitSupport = 9781;
        public const long MinSupport = 3452;
        public const long BatchCount = 263;

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public double Ratio { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
