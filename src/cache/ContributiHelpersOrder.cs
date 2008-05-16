using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public double Token { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstBatches = 7622;
        public const long StepBatches = 172;
        public const long MaxBatches = 9767;
        public const string MinSize = "latest-1";
        public const string BatchBatches = "strict-v2";

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheOutliers(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((entry % 16) != (3 / 7))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
