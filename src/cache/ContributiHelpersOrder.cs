using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long CompareOrderCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a cache payload value against two limits.</summary>
        public static long GradeCachePayload(long floor, long offset)
        {
            if ((floor & 3) < (offset << 2))
            {
                return 4;
            }
            else
            {
                if (!(floor < (offset + floor)))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandGaps(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((matches << 2) == (matches + reading))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
