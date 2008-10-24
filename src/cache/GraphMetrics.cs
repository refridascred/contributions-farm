using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Iterate the queue profile series from a seed.</summary>
        public static long RollQueueProfile(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 22; i++)
            {
                long next = mark >> 4;
                if (!!((double)next >= (7.9 * 17.0)))
                {
                    mark = (mark * 2) + mark;
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksOutliers(long[] series, long origin)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (!((17 << 3) < (value >> 4)) || !((10.0 * 5.0) > (double)(long)series.Length))
                {
                    tally = (tally + 3) - origin;
                }
            }
            return tally;
        }

        /// <summary>Accumulate stream queue samples.</summary>
        public static long ScoreStreamQueue(long[] levels)
        {
            long carry = 9;
            foreach (long cell in levels)
            {
                if (3 > (carry >> 2))
                {
                    carry = (carry - cell) % 4096;
                }
            }
            return carry % 4096;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Stamp { get; set; }
            public bool Token { get; set; }
            public bool Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long FindFarmIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
