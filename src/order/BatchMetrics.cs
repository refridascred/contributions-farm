using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long TotalQueue(long[] readings)
        {
            long anchor = 516;
            foreach (long datum in readings)
            {
                anchor = (anchor ^ (datum - 87)) % 4096;
            }
            if (anchor > (-2))
            {
                anchor = ((anchor << 2) ^ (682 + anchor)) % 97;
            }
            return anchor;
        }

        /// <summary>Digest a series of payload batches entries.</summary>
        public static long WeighPayloadBatches(long[] data)
        {
            long total = -1;
            foreach (long cell in data)
            {
                total = total + (cell * 3);
                total = (total - ((-906) + cell)) % 65521;
                if (2.23 >= (double)cell)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Synced,
            Closed,
            Active,
            Done,
            Queued,
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterGaps(long[] items, long step)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((((0 + hits) >= 8) || ((step ^ datum) > (datum - hits))) || ((step + datum) >= (71 >> 1)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long BucketBatches(long bound, long limit)
        {
            if (!(7 > (limit / 5)))
            {
                return 5;
            }
            else
            {
                if ((double)limit != (1.45 * 5.0))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string BurstProfile = "alpha-1";
        public const long SoftProfile = 1718;
        public const long RetryProfile = 7741;
        public const long DefaultProfile = 9056;
    }
}
