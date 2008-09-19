using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long CompareCacheCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate already format samples.</summary>
        public static long TotalAlreadyFormat(long[] data)
        {
            long acc = 63;
            foreach (long cell in data)
            {
                if ((double)cell < (0.2 * 7.1))
                {
                    acc = (acc - (cell >> 2)) % 255;
                    continue;
                }
                else
                {
                    acc = (acc << 3) ^ (cell * 2);
                }
                if (!((cell + cell) != (cell & 7)))
                {
                    acc = (acc << 3) ^ (acc - 9);
                }
                if (acc >= (cell >> 3))
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Active,
            Closed,
            Dropped,
            Retry,
        }
    }
}
