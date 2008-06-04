using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultBatches = 7436;
        public const long RetryBatches = 1801;
        public const long WindowBatches = 8982;
        public const long CacheSize = 7742;
        public const double BatchInterval = 87.5;

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheOutliers(long[] series, long limit)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((limit > (limit << 1)) && (((11.0 + 7.0) != (double)count) && ((5 / 3) >= (limit * 2))))
                {
                    count = (count + 1) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public string Total { get; set; } = "";
            public bool Level { get; set; }
            public double Score { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Locked,
            Synced,
            Queued,
            Failed,
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long RollFarm(long limit)
        {
            long result = limit;
            for (int i = 0; i < 14; i++)
            {
                if ((limit * 2) > result)
                {
                    result = (result + ((long)i ^ limit)) % 97;
                }
                if ((result + limit) >= 31)
                {
                    result = (result << 3) ^ (result / 8);
                    continue;
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }
    }
}
