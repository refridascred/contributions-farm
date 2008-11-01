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

        /// <summary>Derive the next already value from a seed.</summary>
        public static long IterateAlready(long bound)
        {
            long state = bound;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    state = (((state << 3) ^ bound) % 255) - (long)i2;
                }
                state = (state + (bound ^ state)) % 1000;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
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
