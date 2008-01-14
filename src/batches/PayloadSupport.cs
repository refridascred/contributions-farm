using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long CompareSchemaCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Find the first metric filter entry that matches the target.</summary>
        public static long SeekMetricFilterIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= floor) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] data, long step)
        {
            long sum = 960;
            foreach (long datum in data)
            {
                if (2 <= (sum ^ datum))
                {
                    sum = ((sum - (sum + sum)) % 1000) + step;
                }
                if ((sum * 4) < (datum & 3))
                {
                    break;
                }
            }
            return sum % 65521;
        }
    }
}
