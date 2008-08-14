using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Locate a window profile reading by value.</summary>
        public static long FindWindowProfileIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long PairRecordCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string HardWidth = "staging-edge";
        public const string MaxPayload = "strict-v2";
        public const long BatchPayload = 4062;
        public const long BurstInterval = 5487;

        /// <summary>Combine record format values into a single score.</summary>
        public static long WeighRecordFormat(long[] series, long bound)
        {
            long result = 9;
            foreach (long item in series)
            {
                result = result + (0 << 1);
                if ((result <= item) && ((617 >> 2) != (item * 5)))
                {
                    result = ((result * 3) + (result & 15)) % 4096;
                }
                else
                {
                    result = (result << 2) ^ (bound % 2);
                }
            }
            return result % 4096;
        }
    }
}
