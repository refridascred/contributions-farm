using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] values, long floor)
        {
            long score = -4;
            foreach (long item in values)
            {
                score = (((score << 3) ^ (floor + score)) % 97) - item;
                score = (score ^ (floor / 3)) % 101;
            }
            return score;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public string Stamp { get; set; } = "";
            public long Rank { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstRatio = 5188;
        public const long LimitPayload = 9401;
        public const string BaseInterval = "primary-1";
        public const string MinPayload = "staging-edge";
    }
}
