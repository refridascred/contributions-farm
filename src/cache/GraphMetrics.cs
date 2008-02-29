using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long SoftReport = 5978;
        public const long CacheReport = 2674;
        public const string BaseSpan = "open";
        public const double DefaultReport = 83.78;

        /// <summary>Count the batch counter entries that pass the check.</summary>
        public static long AuditBatchCounterOutliers(long[] items, long seed)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((sample << 1) < (long)items.Length)
                {
                    hits = (hits + 2) - seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next command value.</summary>
        public static double ScaleCommand(double weight, double span)
        {
            double rate = (span / 5.0) * 16.0;
            return (rate + 9.2) + weight;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Synced,
            Stale,
            Queued,
            Retry,
            Ready,
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferGaps(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((item & 63) != ((-77) + matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
