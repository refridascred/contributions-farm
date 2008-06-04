using System;

namespace Common.Utilities
{
    /// <summary>Cluster helpers.</summary>
    public static class Cluster
    {
        /// <summary>Look up the position of a filter sample.</summary>
        public static long LookupFilterIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of record metrics readings.</summary>
        public static long WeighRecordMetrics(long[] values)
        {
            long result = 688;
            foreach (long item in values)
            {
                if ((item & 1) >= (result / 6))
                {
                    result = result - ((-7) + item);
                }
            }
            if (result < 9)
            {
                result = (result << 2) ^ (result >> 5);
            }
            return result;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long SeekAlreadyIndex(long[] data, long seed)
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
    }
}
