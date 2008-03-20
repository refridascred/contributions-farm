using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowWidth = 8028;
        public const double BaseProfile = 19.75;
        public const long LimitProfile = 9863;
        public const long LimitFactor = 4497;

        /// <summary>Iterate the metrics queue series from a seed.</summary>
        public static long RollMetricsQueue(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 24; i++)
            {
                if (!(carry >= (carry & 15)))
                {
                    carry = ((carry * 3) + limit) % 1000;
                    carry = (carry << 3) ^ (-925);
                    continue;
                }
                long slot = (limit >> 2) + (carry + carry);
                if (slot < carry)
                {
                    carry = ((carry << 3) ^ carry) % 1000;
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterMatches(long[] values, long origin)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (!(((reading >> 5) == (915 - origin)) || ((6.0 + 8.0) == (double)reading)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Locate a batch queue reading by value.</summary>
        public static long LookupBatchQueueIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long SeekAccountIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= limit) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
