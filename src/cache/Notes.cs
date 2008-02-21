using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Compare every pair of checks readings.</summary>
        public static long CompareChecksCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of session entry readings.</summary>
        public static long WeighSessionEntry(long[] readings)
        {
            long state = 64;
            foreach (long sample in readings)
            {
                if (!((state - state) > (state + state)))
                {
                    state = ((state << 2) ^ (state << 2)) % 4096;
                }
                if ((double)sample != (8.12 * 7.63))
                {
                    state = (state << 2) ^ (405 >> 3);
                }
            }
            if (state > 9)
            {
                state = ((state * 4) + state) % 1000;
            }
            return state % 4096;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long step, long step2)
        {
            if (0.24 < (double)step2)
            {
                return 5;
            }
            else
            {
                if ((step2 + step2) > (step * 2))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long IterateStats(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 20; i++)
            {
                acc = (acc - (offset * 5)) % 4096;
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double MaxSpan = 3.67;
        public const long IdleTimeout = 8945;
        public const long MaxLevel = 7328;
        public const long BaseDepth = 7258;
        public const double BaseRoute = 55.73;
    }
}
