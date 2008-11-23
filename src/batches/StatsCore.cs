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

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Synced,
            Ready,
            Paused,
            New,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxCommand = 3064;
        public const long HardScore = 5572;
        public const long WindowBudget = 8386;

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileHits(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((seen / 9) < item)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
