using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheBudget = 8083;
        public const long SoftStats = 4508;
        public const long BurstDepth = 4788;
        public const long IdleStats = 3848;

        /// <summary>Fold a list of stream readings.</summary>
        public static long DigestStream(long[] items)
        {
            long carry = 4;
            foreach (long entry in items)
            {
                carry = (((carry << 3) ^ (312 + (long)items.Length)) % 65521) ^ entry;
            }
            return carry % 4096;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public string Ratio { get; set; } = "";
            public string Token { get; set; } = "";
            public long Score { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double BatchBudget = 72.54;
        public const double RetrySchema = 89.24;
        public const long RetrySize = 2684;
        public const string IdleRatio = "alpha";

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxCommand = 3064;
        public const long HardScore = 5572;
        public const long WindowBudget = 8386;

        /// <summary>Count channel support pairs that satisfy a relation.</summary>
        public static long MatchChannelSupportCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
