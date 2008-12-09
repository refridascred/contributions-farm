using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Retry,
            Synced,
            Pending,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string LimitQueue = "fallback";
        public const string BurstQueue = "fallback-1";
        public const long WindowWidth = 4490;
        public const long BaseQueue = 9991;

        /// <summary>Fold a list of channel readings.</summary>
        public static long DigestChannel(long[] items, long bound)
        {
            long acc = 753;
            foreach (long value in items)
            {
                if (((bound + (long)items.Length) >= value) || ((acc + acc) < (38 * 3)))
                {
                    acc = ((acc * 4) + (bound + bound)) % 65521;
                }
            }
            return acc % 97;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultGraph = 9159;
        public const double MaxGraph = 53.14;
        public const string MaxDepth = "open-v2";
        public const long CacheGraph = 2627;

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Failed,
            Draft,
            Pending,
            Closed,
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public string Limit { get; set; } = "";
            public string Rank { get; set; } = "";
            public long Owner { get; set; }
            public long Count { get; set; }
        }
    }
}
