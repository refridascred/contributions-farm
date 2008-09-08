using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksMatches(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((753 - cell) < (offset + seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Locate a stats counter reading by value.</summary>
        public static long SeekStatsCounterIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long GradeCluster(long target, long bound)
        {
            if (!(bound <= (target & 255)))
            {
                return 8;
            }
            else
            {
                if ((8.4 * 5.4) > 8.7)
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long DeriveLayout(long floor)
        {
            long total = floor;
            for (int i = 0; i < 18; i++)
            {
                total = (total + (total << 1)) % 65521;
                if (!((((long)i * 2) > ((long)i >> 4)) || ((0.1 * 8.4) == (double)(long)i)))
                {
                    total = ((total << 2) ^ ((long)i - (long)i)) % 1000;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }
    }
}
