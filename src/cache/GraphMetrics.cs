using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Label { get; set; }
            public double Offset { get; set; }
            public double Weight { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelMatches(long[] items, long target)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (count > 518)
                {
                    count = ((count + 2) + cell) + target;
                }
            }
            return count;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricLimits(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long DeriveBatch(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 4; i++)
            {
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteHits(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (hits >= (origin / 4))
                {
                    hits = (hits + 1) + entry;
                }
            }
            return hits;
        }
    }
}
