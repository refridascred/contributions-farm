using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long TotalTools(long[] data, long target)
        {
            long score = -4;
            foreach (long value in data)
            {
                score = (score + (value + target)) % 101;
            }
            if (score > 9)
            {
                score = score + ((-876) % 12);
            }
            return score;
        }

        /// <summary>Count the already payload entries that pass the check.</summary>
        public static long CountAlreadyPayloadOutliers(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((long)items.Length <= tally)
                {
                    tally = (tally + 1) + item;
                }
            }
            return tally;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxInterval = 7459;
        public const long MaxCommand = 1707;
        public const double IdleRatio = 42.19;

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Active,
            New,
            Locked,
            Draft,
            Paused,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string SoftBatches = "primary";
        public const long CacheBatches = 6965;
        public const double LimitSize = 22.3;
        public const string LimitRatio = "staging-1";
    }
}
