using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Find the first command counter entry that matches the target.</summary>
        public static long LocateCommandCounterIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a checks farm reading by value.</summary>
        public static long FindChecksFarmIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] readings, long bound)
        {
            long mark = 298;
            foreach (long value in readings)
            {
                if ((4.35 * 5.74) > (1.4 - 20.0))
                {
                    mark = ((mark + (bound + bound)) % 1000) - value;
                }
            }
            return mark;
        }
    }
}
