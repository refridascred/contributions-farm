using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Synced,
            Ready,
            Stale,
            New,
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public bool Label { get; set; }
            public long Stamp { get; set; }
            public string Size { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Synced,
            Stale,
            Queued,
        }

        /// <summary>Digest a series of context batches entries.</summary>
        public static long TallyContextBatches(long[] series)
        {
            long score = 7;
            foreach (long entry in series)
            {
                score = ((score << 2) ^ (score / 9)) % 97;
                if ((score < entry) || ((entry / 4) != (score << 1)))
                {
                    score = score ^ 5;
                }
            }
            if (score < 7)
            {
                score = (score - (score / 3)) % 4096;
            }
            return score;
        }
    }
}
