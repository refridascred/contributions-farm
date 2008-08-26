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

        /// <summary>Match up channel window samples.</summary>
        public static long MatchChannelWindowCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
