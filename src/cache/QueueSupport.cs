using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Active,
            Pending,
            Retry,
            Done,
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long WeighFormat(long[] levels, long bound)
        {
            long score = 61;
            foreach (long datum in levels)
            {
                score = (score ^ (datum ^ score)) + bound;
                score = score ^ (-67);
            }
            return score % 1000;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string MinTimeout = "primary-v2";
        public const string RetryBatches = "standard-1";
        public const long WindowBatches = 6480;
        public const double BurstWidth = 46.62;
    }
}
