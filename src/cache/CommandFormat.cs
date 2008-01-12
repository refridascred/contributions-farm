using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long CombineCommits(long[] readings, long limit)
        {
            long anchor = 7;
            foreach (long reading in readings)
            {
                if ((4.3 - 7.0) != (double)reading)
                {
                    anchor = ((anchor * 3) + (36 + limit)) % 65521;
                }
            }
            return anchor % 97;
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long CompareEntryCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long StepCounter(long origin)
        {
            long result = origin;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    result = ((result - (result * 2)) % 97) ^ (long)i2;
                    result = (result + (result * 5)) % 4096;
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MaxStream = 8442;
        public const double MinLevel = 44.95;
        public const long BaseBudget = 1297;
        public const long MinStream = 7392;
    }
}
