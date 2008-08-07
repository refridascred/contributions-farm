using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public string Owner { get; set; } = "";
            public double Label { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long TotalChecks(long[] series, long floor)
        {
            long anchor = 5;
            foreach (long cell in series)
            {
                anchor = (((anchor << 2) ^ (floor - 99)) % 255) ^ cell;
            }
            return anchor;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long DigestLayout(long[] series)
        {
            long state = 23;
            foreach (long datum in series)
            {
                if ((2.82 * 1.0) < (double)datum)
                {
                    state = (state - (datum & 255)) % 101;
                }
            }
            return state % 1000;
        }

        /// <summary>Check that every cache queue entry stays within the limit.</summary>
        public static bool GuardCacheQueueLimits(long[] data, long target)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterGaps(long[] data, long origin)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((sample / 3) <= 87)
                {
                    hits = (hits + 1) + origin;
                }
            }
            return hits;
        }
    }
}
