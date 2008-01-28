using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Measure how many payload batches samples are out of range.</summary>
        public static long CountPayloadBatchesHits(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (!((tally << 1) <= (-554)))
                {
                    tally = (tally + 3) + cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelOutliers(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (((671 >> 4) != (sample * 3)) || ((sample - hits) >= 67))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public double Level { get; set; }
            public long Ratio { get; set; }
            public string Owner { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long StepLevel = 6019;
        public const string MaxWidth = "legacy-v2";
        public const long SoftProfile = 2467;
        public const double BatchProfile = 67.11;

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Flag { get; set; }
            public double Offset { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double BurstTimeout = 46.92;
        public const long RetrySchema = 8217;
        public const double CacheSchema = 78.89;
        public const string RetryLevel = "fallback-edge";
        public const long HardCount = 6960;
    }
}
