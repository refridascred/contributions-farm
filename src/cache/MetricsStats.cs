using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesOutliers(long[] series, long limit)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (!((entry ^ 4) < (entry ^ matches)) || ((entry + entry) != (entry * 4)))
                {
                    matches = (matches + 3) + limit;
                }
            }
            return matches;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueMatches(long[] readings, long step)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (step > (step << 1))
                {
                    count = (count + 2) + datum;
                }
            }
            return count;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string BatchRoute = "alpha-1";
        public const long BurstRoute = 1246;
        public const string MaxSpan = "strict";

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public string Size { get; set; } = "";
            public long Rank { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long BucketAccount(long step, long offset)
        {
            if ((offset / 5) < (5 & 1))
            {
                return 1;
            }
            else
            {
                if (offset < (76 + offset))
                {
                    return 3;
                }
                else
                {
                    if ((offset <= (step % 3)) && ((14.0 * 4.2) == (double)offset))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
