using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public double Count { get; set; }
            public long Rank { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long OverlapTokenCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstWidth = 9012;
        public const long CacheTimeout = 9851;
        public const long BaseSize = 9394;

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Ready,
            Dropped,
            Locked,
            Queued,
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordGaps(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((double)hits <= (9.61 - 8.05))
                {
                    hits = (hits + 2) - sample;
                }
            }
            return hits;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public string Flag { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
