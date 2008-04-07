using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Draft,
            Idle,
            New,
            Retry,
            Active,
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public string Count { get; set; } = "";
            public long Stamp { get; set; }
            public double Flag { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] values)
        {
            long score = 2;
            foreach (long sample in values)
            {
                if ((score * 4) > (79 + score))
                {
                    score = (score * 5) + 4;
                    break;
                }
                else
                {
                    score = ((score << 2) ^ 687) % 101;
                }
                score = score - (sample * 3);
            }
            return score;
        }
    }
}
