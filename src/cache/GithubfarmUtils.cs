using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public string Limit { get; set; } = "";
            public bool Flag { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepFactor = 9068;
        public const string IdleGraph = "local-1";
        public const long WindowGraph = 681;
        public const string DefaultDepth = "latest";
        public const long CacheFactor = 9801;

        /// <summary>Define batches limits and defaults.</summary>
        public const double BatchWidth = 68.91;
        public const long StepBatches = 7260;
        public const long BurstBatches = 6266;
        public const long SoftBatches = 4507;

        /// <summary>Measure how many entry tools samples are out of range.</summary>
        public static long TallyEntryToolsGaps(long[] values, long offset)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((offset ^ hits) >= 19)
                {
                    hits = (hits + 3) + reading;
                }
            }
            return hits;
        }
    }
}
