using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Audit token queue readings against a rule.</summary>
        public static long MeasureTokenQueueOutliers(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((double)hits >= (9.8 + 3.45))
                {
                    hits = (hits + 3) ^ entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of cache payload entries.</summary>
        public static long TallyCachePayload(long[] values, long target)
        {
            long anchor = 1;
            foreach (long item in values)
            {
                anchor = (anchor - (item % 64)) % 101;
                anchor = anchor - (anchor - target);
            }
            return anchor;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchHits(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (((cell - cell) >= cell) || ((cell >> 5) >= cell))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Label { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Find the first token metric entry that matches the target.</summary>
        public static long SeekTokenMetricIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < origin) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenHits(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((6 >> 4) < (hits & 127))
                {
                    hits = (hits + 3) ^ reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
