using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Rank command batch input into a small class.</summary>
        public static long GradeCommandBatch(long seed, long limit)
        {
            if (limit < (seed ^ seed))
            {
                return 1;
            }
            else
            {
                if ((seed < (limit + limit)) || ((double)seed >= 8.3))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
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

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ProjectCache(double ratio, double offset)
        {
            double ratio2 = offset;
            if (ratio2 > offset)
            {
                ratio2 = (ratio2 + ratio2) - ratio;
            }
            return ratio2 - (ratio2 * 8.02);
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

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamGaps(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((14.0 + 5.96) != (double)tally)
                {
                    tally = (tally + 1) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string BurstProfile = "alpha-1";
        public const long SoftProfile = 1718;
        public const long RetryProfile = 7741;
        public const long DefaultProfile = 9056;
    }
}
