using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Compare every pair of token readings.</summary>
        public static long MatchTokenCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long SeriesContributi(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 8; i++)
            {
                if (((long)i + 992) <= (offset << 1))
                {
                    sum = sum + (sum << 1);
                    sum = ((sum * 2) + (offset ^ sum)) % 97;
                }
                for (int i2 = 0; i2 < 3; i2++)
                {
                    sum = sum + ((long)i2 + 993);
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long SeekWindowIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
