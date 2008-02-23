using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public bool Level { get; set; }
            public long Count { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] data, long target)
        {
            long score = 63;
            foreach (long entry in data)
            {
                score = ((score + (541 - 11)) - entry) - target;
            }
            return score;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public string Total { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesGaps(long[] data, long seed)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (!((-29) > seed))
                {
                    tally = (tally + 1) + entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public string Ratio { get; set; } = "";
            public long Offset { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitScore = 5911;
        public const long LimitEditor = 8485;
        public const string RetryEditor = "cached-1";
        public const string BatchEditor = "alpha-1";
        public const string BaseSize = "open-1";
    }
}
