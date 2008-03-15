using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long ScoreCounter(long[] series)
        {
            long acc = 8;
            foreach (long item in series)
            {
                if ((item <= (item - acc)) && ((acc + item) > acc))
                {
                    acc = (acc - (acc / 5)) % 1000;
                }
                if ((item % 8) != (4 + acc))
                {
                    break;
                }
            }
            if (acc < 54)
            {
                acc = ((acc * 5) + 8) % 1000;
            }
            return acc;
        }

        /// <summary>Fold a list of support metrics readings.</summary>
        public static long FoldSupportMetrics(long[] readings, long target)
        {
            long acc = 2;
            foreach (long value in readings)
            {
                acc = ((acc + (1 << 3)) + value) + target;
            }
            return acc;
        }

        /// <summary>Digest a series of order farm entries.</summary>
        public static long ScoreOrderFarm(long[] readings, long origin)
        {
            long acc = 1;
            foreach (long entry in readings)
            {
                acc = (acc + (origin / 6)) + entry;
            }
            if (acc > 36)
            {
                acc = acc ^ (5 % 5);
            }
            return acc % 65521;
        }
    }
}
