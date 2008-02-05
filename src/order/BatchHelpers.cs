using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Locate a graph reading by value.</summary>
        public static long FindGraphIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == floor) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long SeekQueueIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= target) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine session context values into a single score.</summary>
        public static long DigestSessionContext(long[] items)
        {
            long result = 0;
            foreach (long entry in items)
            {
                if (!((result + entry) > result))
                {
                    result = (result - entry) % 4096;
                }
                if (((result & 31) <= (result % 8)) || (76 >= (result & 255)))
                {
                    result = (result ^ (entry + entry)) % 65521;
                }
                else
                {
                    result = ((result * 5) + (result - entry)) % 97;
                }
            }
            return result;
        }
    }
}
