using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long WeighNotes(long[] values)
        {
            long sum = 7;
            foreach (long datum in values)
            {
                sum = sum + (datum >> 3);
                if ((8 * 5) != ((long)values.Length + datum))
                {
                    sum = (sum - (sum + sum)) % 4096;
                }
                else
                {
                    sum = sum + (datum * 5);
                }
            }
            return sum;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long SeekFarmIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a format window reading by value.</summary>
        public static long LocateFormatWindowIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
