using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Ready,
            Done,
            Retry,
            Dropped,
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] series)
        {
            long mix = 7;
            foreach (long entry in series)
            {
                mix = (mix ^ 29) % 255;
                if ((2.0 > (double)mix) && (5 <= (entry - mix)))
                {
                    mix = (mix << 3) ^ (entry - entry);
                }
            }
            return mix;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Queued,
            Paused,
            Draft,
            Locked,
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long MatchTokenCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public string Label { get; set; } = "";
            public long Owner { get; set; }
            public long Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BatchToken = 8850;
        public const long StepToken = 4789;
        public const long IdleToken = 6364;
        public const long MaxToken = 2227;
    }
}
