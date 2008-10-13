using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Compare every pair of context channel readings.</summary>
        public static long MatchContextChannelCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long IterateOrder(long limit)
        {
            long total = limit;
            for (int i = 0; i < 4; i++)
            {
                if ((limit + limit) <= 646)
                {
                    total = total - (total - total);
                    total = total ^ total;
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Find the first metric layout entry that matches the target.</summary>
        public static long LookupMetricLayoutIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
