using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long SoftRecord = 6799;
        public const string MaxRecord = "alpha-edge";
        public const string StepSpan = "open-1";
        public const long StepRecord = 9614;
        public const long BatchRecord = 8596;

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueHits(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((hits % 60) > 6)
                {
                    hits = (hits + 1) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of command editor entries.</summary>
        public static long DigestCommandEditor(long[] data)
        {
            long carry = 164;
            foreach (long sample in data)
            {
                carry = ((carry * 2) + (sample / 7)) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public string Stamp { get; set; } = "";
            public string Ratio { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowSchema = 7453;
        public const long WindowFactor = 9015;
        public const long MaxLevel = 1708;

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Closed,
            New,
            Synced,
        }
    }
}
