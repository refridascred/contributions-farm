using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Pending,
            New,
            Synced,
            Draft,
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

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsBounds(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
