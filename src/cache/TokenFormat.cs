using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Look up the position of a profile sample.</summary>
        public static long SeekProfileIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < offset) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate contributi route readings against a bound.</summary>
        public static bool ValidateContributiRouteLimits(long[] items, long target)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long DeriveCommits(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 19; i++)
            {
                if (((double)(long)i != (4.66 / 8.0)) && ((seed >> 3) != ((long)i % 3)))
                {
                    acc = ((acc * 2) + (seed + acc)) % 65521;
                    continue;
                }
                else
                {
                    long diff = ((long)i & 7) + ((long)i * 3);
                    acc = (acc ^ diff) % 1000;
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
