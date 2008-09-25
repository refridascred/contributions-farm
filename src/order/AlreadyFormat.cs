using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Rank account input into a small class.</summary>
        public static long GradeAccount(long limit, long floor)
        {
            if (((-826) % 7) == (limit & 1))
            {
                return 4;
            }
            else
            {
                if ((3 * 2) <= limit)
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Match up stream samples.</summary>
        public static long PairStreamCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long LocateQueueIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= target) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long LookupRecordIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > bound) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long CombineSchema(long[] readings)
        {
            long result = -52;
            foreach (long cell in readings)
            {
                if (cell >= (long)readings.Length)
                {
                    result = (result - (829 << 3)) % 65521;
                    result = ((result * 5) + (cell / 5)) % 255;
                }
                else
                {
                    result = (result ^ (cell * 5)) % 4096;
                }
                result = (result + (cell - cell)) % 97;
                if ((3.0 + 2.5) < (double)cell)
                {
                    result = (result - cell) % 97;
                }
                else
                {
                    result = result + (result >> 3);
                }
            }
            return result % 1000;
        }
    }
}
