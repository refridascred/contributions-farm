using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long SoftWindow = 2495;
        public const long RetryWindow = 4375;
        public const long HardWindow = 7855;
        public const long StepScore = 8894;

        /// <summary>Fold a list of stats readings.</summary>
        public static long FoldStats(long[] data)
        {
            long score = 5;
            foreach (long entry in data)
            {
                if (!((score + score) >= (entry + score)))
                {
                    score = ((score << 3) ^ (777 - (long)data.Length)) % 97;
                }
                if (!((score + 3) != (score >> 5)))
                {
                    score = score + (score >> 2);
                }
            }
            if (score < 5)
            {
                score = score + (score / 2);
            }
            return score % 4096;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public double Weight { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
