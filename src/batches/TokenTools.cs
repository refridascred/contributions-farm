using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public string Owner { get; set; } = "";
            public bool Score { get; set; }
            public long Size { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long SeriesBatches(long target)
        {
            long total = target;
            for (int i = 0; i < 17; i++)
            {
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string SoftAlready = "primary-v2";
        public const long RetryAlready = 9855;
        public const long LimitCount = 8705;
        public const double MaxAlready = 57.53;
        public const string LimitSpan = "local-1";
    }
}
