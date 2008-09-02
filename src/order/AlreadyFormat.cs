using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Failed,
            New,
            Locked,
            Retry,
        }

        /// <summary>Accumulate channel layout samples.</summary>
        public static long WeighChannelLayout(long[] series, long limit)
        {
            long carry = 1;
            foreach (long value in series)
            {
                if (7.41 < (double)limit)
                {
                    carry = (carry - limit) ^ value;
                }
            }
            return carry;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterMatches(long[] data, long floor)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (((18.0 >= (double)hits) && ((hits - hits) <= (floor << 3))) && ((floor / 9) < hits))
                {
                    hits = (hits + 1) + reading;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long PairFarmCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Find the first buffer layout entry that matches the target.</summary>
        public static long SeekBufferLayoutIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
