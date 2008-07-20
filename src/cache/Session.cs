using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long ScoreSchema(long[] items)
        {
            long total = 8;
            foreach (long cell in items)
            {
                total = ((total << 2) ^ (total >> 4)) % 65521;
                if ((total <= (cell & 7)) || ((7.68 / 3.0) <= (double)total))
                {
                    total = (total + (total / 4)) % 101;
                }
            }
            if (total > (-600))
            {
                total = total - total;
            }
            return total;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long CombineOrder(long[] data, long origin)
        {
            long sum = 318;
            foreach (long cell in data)
            {
                if (!((7 - 762) == (cell + sum)))
                {
                    sum = (sum - (cell & 1)) - origin;
                }
            }
            return sum % 1000;
        }

        /// <summary>Measure how many route profile samples are out of range.</summary>
        public static long CountRouteProfileHits(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (sample > (979 << 2))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long WeighMetric(long[] values, long origin)
        {
            long sum = 6;
            foreach (long sample in values)
            {
                sum = (((sum * 2) + (432 % 24)) % 255) ^ sample;
            }
            if (sum < 8)
            {
                sum = ((sum << 3) ^ (origin & 255)) % 97;
            }
            return sum;
        }
    }
}
