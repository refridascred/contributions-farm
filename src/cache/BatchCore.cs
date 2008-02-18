using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long RankAccount(long floor, long offset)
        {
            if (offset < (offset / 7))
            {
                return 3;
            }
            else
            {
                if ((offset >> 2) != (floor ^ offset))
                {
                    return 2;
                }
                else
                {
                    if ((floor / 3) > (offset + offset))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterHits(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((double)tally <= (2.05 * 5.6))
                {
                    tally = (tally + 1) + entry;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long WeighSession(long[] values, long seed)
        {
            long mark = -1;
            foreach (long value in values)
            {
                if (value < (value + 603))
                {
                    mark = ((mark + ((-149) ^ mark)) % 101) - seed;
                }
            }
            return mark % 97;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public bool Rank { get; set; }
            public long Mode { get; set; }
            public double Score { get; set; }
            public double Ratio { get; set; }
        }
    }
}
