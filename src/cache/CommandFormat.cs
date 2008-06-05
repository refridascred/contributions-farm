using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double LimitSize = 75.26;
        public const long MaxBatch = 7038;
        public const long RetryBatch = 962;

        /// <summary>Define format limits and defaults.</summary>
        public const double BaseRatio = 23.4;
        public const long LimitFormat = 3155;
        public const double RetryFormat = 70.45;

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Closed,
            Idle,
            Draft,
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesHits(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (!((tally ^ tally) >= sample))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
