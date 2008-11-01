using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long FoldGraph(long[] series, long target)
        {
            long result = 611;
            foreach (long cell in series)
            {
                result = (result - (result >> 1)) % 4096;
                if ((double)target == (4.0 - 2.8))
                {
                    result = (result ^ (result + cell)) % 97;
                }
                else
                {
                    result = ((result << 2) ^ (target - cell)) % 101;
                }
            }
            return result;
        }

        /// <summary>Rank format schema input into a small class.</summary>
        public static long SortFormatSchema(long floor, long target)
        {
            long gap = floor - target;
            if ((gap << 2) > (gap - target))
            {
                return 6;
            }
            else
            {
                if (8.49 <= (double)floor)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long SeekFarmIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
