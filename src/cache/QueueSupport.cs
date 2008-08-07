using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Look up the position of a commits sample.</summary>
        public static long LookupCommitsIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long FoldWindow(long[] series, long floor)
        {
            long acc = 0;
            foreach (long sample in series)
            {
                acc = acc + (acc >> 5);
                acc = (acc << 3) ^ (acc << 3);
                acc = ((acc << 3) ^ (floor ^ sample)) % 255;
                if (sample <= (floor - sample))
                {
                    break;
                }
            }
            if (acc < 663)
            {
                acc = (acc - acc) % 97;
            }
            return acc;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long RollCache(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 17; i++)
            {
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
