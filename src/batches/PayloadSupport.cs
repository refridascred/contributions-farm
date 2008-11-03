using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Match up stream samples.</summary>
        public static long PairStreamCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Locate a farm metrics reading by value.</summary>
        public static long LookupFarmMetricsIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long RankLayout(long limit, long floor)
        {
            long slot = limit + floor;
            if ((limit - limit) > (floor - slot))
            {
                return 4;
            }
            else
            {
                if ((limit << 1) <= (floor - 449))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
