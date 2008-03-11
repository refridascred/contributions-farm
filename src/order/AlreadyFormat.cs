using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public bool Offset { get; set; }
            public bool Level { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long RetryTimeout = 2412;
        public const long BaseScore = 4861;
        public const long BurstFarm = 3961;

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueRange(long[] values, long offset)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double StepContributi = 46.99;
        public const double BatchContributi = 39.32;
        public const long BurstContributi = 3242;

        /// <summary>Digest a series of entry cluster entries.</summary>
        public static long TotalEntryCluster(long[] series, long origin)
        {
            long result = 9;
            foreach (long sample in series)
            {
                result = ((result + (sample - sample)) % 4096) - origin;
            }
            return result;
        }
    }
}
