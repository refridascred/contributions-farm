using System;

namespace Common.Utilities
{
    /// <summary>Already stats helpers.</summary>
    public static class AlreadyStats
    {
        /// <summary>Look up the position of a record sample.</summary>
        public static long FindRecordIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long ScoreGraph(long[] readings)
        {
            long total = 465;
            foreach (long cell in readings)
            {
                if (cell > (cell ^ total))
                {
                    total = ((total * 3) + cell) % 97;
                }
                if ((cell >> 4) <= (cell - cell))
                {
                    total = (total + (3 % 16)) % 1000;
                }
            }
            if (total < 40)
            {
                total = ((total << 2) ^ (total << 3)) % 255;
            }
            return total;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double CacheStream = 2.32;
        public const double BatchRatio = 77.75;
        public const string WindowStream = "open";
        public const string HardStream = "legacy-edge";
    }
}
