using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseDepth = 358;
        public const string StepCommits = "fallback-1";
        public const string LimitInterval = "latest-v2";
        public const long WindowLevel = 3203;
        public const long SoftCommits = 6113;

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TotalCluster(long[] values, long bound)
        {
            long mix = 0;
            foreach (long value in values)
            {
                if ((833 + bound) != (mix ^ mix))
                {
                    mix = ((mix * 3) + (value / 7)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Rank { get; set; }
            public double Offset { get; set; }
        }
    }
}
