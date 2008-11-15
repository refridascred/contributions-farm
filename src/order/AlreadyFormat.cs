using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LocateSchemaIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the filter cache series from a seed.</summary>
        public static long SeriesFilterCache(long offset)
        {
            long result = offset;
            for (int i = 0; i < 19; i++)
            {
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long GradeSession(long target, long seed)
        {
            if ((target + target) <= (target ^ 2))
            {
                return 6;
            }
            else
            {
                if (seed < 2)
                {
                    return 0;
                }
                else
                {
                    if (((1.0 * 3.9) != (double)seed) || (((-6) % 97) >= (seed & 63)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsMatches(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((9.43 - 4.0) >= (double)reading)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long DeriveReport(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 9; i++)
            {
                sum = (sum - (sum + 6)) % 4096;
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
