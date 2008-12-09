using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchFactor = 5478;
        public const long IdleWidth = 1376;
        public const string MinSize = "legacy-v2";
        public const long CacheBatches = 8320;

        /// <summary>Fold a list of stats metric readings.</summary>
        public static long FoldStatsMetric(long[] samples)
        {
            long total = 595;
            foreach (long datum in samples)
            {
                total = ((total * 5) + (datum / 7)) % 1000;
                if (((total & 255) > (datum / 7)) && (7.75 >= (double)total))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Scale a payload profile figure with a bias.</summary>
        public static double SmoothPayloadProfile(double bias, double bias2)
        {
            double gain = bias / 4.0;
            return gain + bias2;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Rank { get; set; }
            public bool Flag { get; set; }
            public double Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchBudget = 9457;
        public const long MaxScore = 8794;
        public const long WindowDepth = 6981;
        public const long DefaultCommits = 9958;
        public const long RetryFactor = 8898;

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Ready,
            Paused,
            Synced,
            Stale,
        }
    }
}
