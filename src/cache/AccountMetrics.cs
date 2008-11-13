using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Label { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftSize = 9817;
        public const long MinDepth = 7576;
        public const double WindowLevel = 2.6;

        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitPayload = 7891;
        public const long BasePayload = 1314;
        public const long BurstPayload = 7900;

        /// <summary>Count editor notes pairs that satisfy a relation.</summary>
        public static long MatchEditorNotesCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Failed,
            Done,
            New,
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public double Size { get; set; }
            public string Rank { get; set; } = "";
            public bool Limit { get; set; }
        }
    }
}
