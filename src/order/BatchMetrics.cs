using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Synced,
            Closed,
            Dropped,
            New,
            Idle,
        }

        /// <summary>Check that every counter already entry stays within the limit.</summary>
        public static bool CheckCounterAlreadyLimits(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Token { get; set; }
            public string Count { get; set; } = "";
            public double Size { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public bool Mode { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Fold a list of metric contributi readings.</summary>
        public static long DigestMetricContributi(long[] items)
        {
            long mix = -183;
            foreach (long datum in items)
            {
                mix = ((mix + (mix & 15)) % 97) + datum;
            }
            return mix % 65521;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesHits(long[] series, long target)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((1.9 - 5.5) == (double)target)
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }
    }
}
