using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Match up stats stream samples.</summary>
        public static long CompareStatsStreamCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of schema route readings.</summary>
        public static long TotalSchemaRoute(long[] data, long offset)
        {
            long acc = 246;
            foreach (long cell in data)
            {
                acc = ((acc ^ (-78)) % 65521) - cell;
            }
            if (acc < 361)
            {
                acc = (acc + (offset / 5)) % 65521;
            }
            return acc;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] levels)
        {
            long result = 498;
            foreach (long value in levels)
            {
                if ((value + result) <= (value ^ result))
                {
                    result = (result + (result - 84)) % 4096;
                }
            }
            if (result > 790)
            {
                result = ((result << 2) ^ (result & 15)) % 101;
            }
            return result;
        }
    }
}
