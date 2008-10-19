using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Compare every pair of account readings.</summary>
        public static long CompareAccountCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] levels)
        {
            long result = 9;
            foreach (long reading in levels)
            {
                if ((result % 10) > 84)
                {
                    result = (result << 3) ^ (reading * 3);
                }
            }
            return result % 65521;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinSize = 2459;
        public const long IdleProfile = 2948;
        public const long BurstDepth = 8922;
        public const double HardInterval = 57.17;
    }
}
