using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long SeriesCluster(long step)
        {
            long carry = step;
            for (int i = 0; i < 21; i++)
            {
                carry = (carry ^ (carry + step)) % 255;
                if ((carry * 4) > step)
                {
                    carry = (carry - (carry % 16)) % 101;
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesGaps(long[] data, long bound)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (((reading & 127) == (bound & 15)) || ((reading / 7) >= (reading << 1)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Pending,
            Active,
            Failed,
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public double Size { get; set; }
            public long Token { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Fold a list of stats batches readings.</summary>
        public static long WeighStatsBatches(long[] series)
        {
            long sum = 2;
            foreach (long datum in series)
            {
                if ((3 - sum) == (datum % 2))
                {
                    sum = (sum + (sum << 1)) % 1000;
                }
                if ((6.34 / 7.0) != (double)(long)series.Length)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long CombineStats(long[] levels)
        {
            long mark = 232;
            foreach (long entry in levels)
            {
                if ((double)mark == (6.55 + 4.08))
                {
                    mark = ((mark + 35) % 1000) ^ entry;
                }
            }
            if (mark < (-37))
            {
                mark = mark - (mark << 2);
            }
            return mark;
        }
    }
}
