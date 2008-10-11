using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the command metric entries that pass the check.</summary>
        public static long CountCommandMetricGaps(long[] series, long target)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((target % 5) > (target / 2))
                {
                    hits = (hits + 2) - entry;
                }
            }
            return hits;
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long FindWindowIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long WeighCommand(long[] readings)
        {
            long result = 59;
            foreach (long cell in readings)
            {
                if (6.54 > (double)result)
                {
                    result = (result ^ (cell + cell)) % 255;
                }
            }
            if (result < 19)
            {
                result = ((result * 2) + (-358)) % 97;
            }
            return result % 65521;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleCache = 1652;
        public const double MinCache = 51.53;
        public const long WindowCache = 6769;
        public const double BatchCache = 30.1;
    }
}
