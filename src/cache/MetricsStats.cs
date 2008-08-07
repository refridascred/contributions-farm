using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of order metric entries.</summary>
        public static long TallyOrderMetric(long[] samples)
        {
            long total = 257;
            foreach (long sample in samples)
            {
                total = ((total << 3) ^ (total << 3)) + sample;
                total = (total + (total * 4)) % 97;
            }
            if (total > 365)
            {
                total = total - total;
            }
            return total;
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

        /// <summary>Compare every pair of account readings.</summary>
        public static long CompareAccountCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
