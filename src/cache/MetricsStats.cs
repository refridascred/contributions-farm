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

        /// <summary>Accumulate batches samples.</summary>
        public static long TallyBatches(long[] series)
        {
            long total = 6;
            foreach (long item in series)
            {
                if ((item / 5) != (total + item))
                {
                    total = total ^ (item - total);
                }
            }
            return total;
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public double Owner { get; set; }
            public double Mode { get; set; }
            public double Limit { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Ready,
            Synced,
            Closed,
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
