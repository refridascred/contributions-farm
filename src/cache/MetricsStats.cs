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

        /// <summary>Rank account input into a small class.</summary>
        public static long SortAccount(long offset, long limit)
        {
            if ((limit >> 5) == (5 >> 1))
            {
                return 4;
            }
            else
            {
                if ((double)offset > (double)limit)
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
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
