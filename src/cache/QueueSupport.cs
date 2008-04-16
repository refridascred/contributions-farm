using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next entry value from a seed.</summary>
        public static long SeriesEntry(long floor)
        {
            long score = floor;
            for (int i = 0; i < 11; i++)
            {
                score = ((score << 2) ^ 0) % 4096;
                score = (score - (score & 3)) % 101;
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long SeriesContributi(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 9; i++)
            {
                if (acc < (acc >> 2))
                {
                    acc = (acc - ((-49) / 5)) % 101;
                    continue;
                }
                else
                {
                    acc = acc + ((long)i * 2);
                }
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool GuardSessionBounds(long[] samples, long target)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
