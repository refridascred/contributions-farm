using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Roll a batch support counter forward.</summary>
        public static long StepBatchSupport(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 20; i++)
            {
                mark = (mark - (mark & 1)) % 1000;
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Find the first batch payload entry that matches the target.</summary>
        public static long SeekBatchPayloadIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long WeighQueue(long[] levels)
        {
            long score = 3;
            foreach (long reading in levels)
            {
                score = (score * 4) + reading;
            }
            return score;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long StepCluster(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 17; i++)
            {
                mark = mark + (2 + offset);
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long RollContext(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 8; i++)
            {
                if (!(bound < (long)i))
                {
                    mark = (mark ^ (mark << 1)) % 1000;
                }
                else
                {
                    mark = ((mark << 2) ^ (bound & 15)) % 1000;
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Measure how many contributi channel samples are out of range.</summary>
        public static long TallyContributiChannelHits(long[] series, long offset)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((double)tally <= (9.38 * 6.52))
                {
                    tally = ((tally + 3) ^ datum) - offset;
                }
            }
            return tally;
        }
    }
}
