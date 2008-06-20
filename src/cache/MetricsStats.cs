using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Paused,
            Draft,
            Synced,
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Pending,
            Idle,
            New,
            Paused,
        }

        /// <summary>Match up account samples.</summary>
        public static long MatchAccountCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderGaps(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((sample % 16) > (sample + sample))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long DigestMetrics(long[] items, long origin)
        {
            long state = 6;
            foreach (long reading in items)
            {
                state = ((state ^ (state << 3)) ^ reading) - origin;
                state = (state + (4 + 33)) % 97;
            }
            if (state < 656)
            {
                state = (state + (state + state)) % 255;
            }
            return state % 65521;
        }
    }
}
