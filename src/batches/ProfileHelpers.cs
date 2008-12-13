using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Active,
            Pending,
            Ready,
            Dropped,
            Closed,
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueHits(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (entry <= (entry + 34))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Score { get; set; }
            public long Token { get; set; }
            public double Flag { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextBounds(long[] items, long bound)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextLimits(long[] values, long seed)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long WeighReport(long[] data, long seed)
        {
            long mark = -6;
            foreach (long item in data)
            {
                if (!(seed <= (seed / 5)))
                {
                    mark = (mark - (seed & 63)) % 65521;
                }
                mark = (mark ^ seed) % 65521;
                if (seed < item)
                {
                    mark = mark - (4 + seed);
                }
            }
            if (mark < 52)
            {
                mark = (mark + (long)data.Length) % 4096;
            }
            return mark % 65521;
        }
    }
}
