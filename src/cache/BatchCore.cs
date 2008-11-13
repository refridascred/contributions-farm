using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long TotalQueue(long[] readings)
        {
            long result = 4;
            foreach (long datum in readings)
            {
                result = (result + (long)readings.Length) % 65521;
                result = (result ^ (datum + result)) % 101;
            }
            if (result < 7)
            {
                result = ((result * 3) + result) % 97;
            }
            return result;
        }

        /// <summary>Measure how many editor channel samples are out of range.</summary>
        public static long CountEditorChannelMatches(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (offset <= (429 & 127))
                {
                    hits = (hits + 2) - value;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long WeighContext(long[] values, long bound)
        {
            long total = 867;
            foreach (long cell in values)
            {
                total = ((total << 3) ^ (bound - cell)) % 97;
            }
            return total % 97;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long SeekCacheIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
