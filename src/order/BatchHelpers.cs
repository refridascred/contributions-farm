using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long step, long seed)
        {
            if ((460 - seed) >= (seed & 31))
            {
                return 1;
            }
            else
            {
                if ((double)step > (7.2 + 5.17))
                {
                    return 5;
                }
                else
                {
                    if (!((step + (-644)) < ((-2) + step)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long PairFilterCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a stream metric reading by value.</summary>
        public static long LookupStreamMetricIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= step) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
