using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Failed,
            Closed,
            Draft,
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long IterateBatch(long floor)
        {
            long score = floor;
            for (int i = 0; i < 6; i++)
            {
                score = score ^ floor;
                score = ((score << 2) ^ (318 - score)) % 4096;
                if ((-6) >= floor)
                {
                    score = (score - floor) % 4096;
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long SeekBatchesIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long IterateProfile(long origin)
        {
            long state = origin;
            for (int i = 0; i < 21; i++)
            {
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }
    }
}
