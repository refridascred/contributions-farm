using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Locate a token contributi reading by value.</summary>
        public static long SeekTokenContributiIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank buffer farm input into a small class.</summary>
        public static long SortBufferFarm(long seed, long seed2)
        {
            long offset = seed - seed2;
            if ((double)seed2 == (5.4 * 3.0))
            {
                return 1;
            }
            else
            {
                if ((double)seed >= (0.8 + 4.0))
                {
                    return 5;
                }
                else
                {
                    if ((offset - seed2) < (offset - seed))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long MatchMetricCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
