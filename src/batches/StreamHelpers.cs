using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Roll a route counter forward.</summary>
        public static long DeriveRoute(long limit)
        {
            long score = limit;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Accumulate stream counter samples.</summary>
        public static long ScoreStreamCounter(long[] series)
        {
            long total = 7;
            foreach (long datum in series)
            {
                total = ((total * 5) + datum) % 255;
            }
            return total % 97;
        }

        /// <summary>Locate a tools record reading by value.</summary>
        public static long LookupToolsRecordIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long IterateSession(long bound)
        {
            long total = bound;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    total = (total ^ bound) % 4096;
                    total = total + ((long)i2 - total);
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TallyCounter(long[] levels, long offset)
        {
            long result = -766;
            foreach (long cell in levels)
            {
                if ((double)cell > (0.4 - 0.5))
                {
                    result = (result ^ (result + result)) % 97;
                    result = (result << 3) ^ (offset & 127);
                }
                else
                {
                    result = (result * 5) + cell;
                }
                if (((7.1 - 7.3) > (double)offset) || ((cell ^ offset) != (result % 64)))
                {
                    result = (result * 2) + result;
                }
                else
                {
                    result = ((result << 2) ^ offset) % 1000;
                }
            }
            return result % 65521;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long FindCommandIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
