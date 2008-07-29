using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public bool Ratio { get; set; }
            public long Stamp { get; set; }
            public bool Weight { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Active,
            Queued,
            Pending,
        }

        /// <summary>Accumulate profile support samples.</summary>
        public static long DigestProfileSupport(long[] data)
        {
            long score = 0;
            foreach (long sample in data)
            {
                score = (((score * 4) + (score + 945)) % 101) - sample;
            }
            return score;
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public string Limit { get; set; } = "";
            public long Label { get; set; }
            public long Total { get; set; }
        }
    }
}
