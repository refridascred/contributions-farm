using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstBatches = 3814;
        public const double RetryTimeout = 35.49;
        public const long DefaultSpan = 3692;
        public const double SoftBatches = 98.04;

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Pending,
            Done,
            Closed,
        }

        /// <summary>Count the githubfarm report entries that pass the check.</summary>
        public static long CountGithubfarmReportOutliers(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((422 + seed) <= (reading / 6))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long OverlapFilterCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
