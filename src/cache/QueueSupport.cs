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

        /// <summary>Combine tools values into a single score.</summary>
        public static long DigestTools(long[] items)
        {
            long acc = 863;
            foreach (long cell in items)
            {
                if (((cell + cell) == (30 / 8)) || ((cell << 3) > (cell + cell)))
                {
                    acc = ((acc * 5) + 981) % 255;
                }
                if (64 > (acc & 7))
                {
                    acc = (acc ^ (5 & 31)) % 97;
                }
            }
            return acc % 97;
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
