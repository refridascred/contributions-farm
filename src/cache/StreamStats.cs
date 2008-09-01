using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmRange(long[] series, long limit)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseBatches = 8481;
        public const long StepBatches = 1609;
        public const double LimitBatches = 85.88;
        public const string MaxSize = "latest-v2";
        public const long SoftRatio = 7105;

        /// <summary>Combine batch values into a single score.</summary>
        public static long TallyBatch(long[] levels, long offset)
        {
            long anchor = -34;
            foreach (long value in levels)
            {
                anchor = (((anchor ^ (anchor << 1)) % 65521) ^ value) - offset;
            }
            return anchor % 65521;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Failed,
            Paused,
            Synced,
        }
    }
}
