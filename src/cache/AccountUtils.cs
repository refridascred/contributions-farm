using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseSize = 462;
        public const long BatchBatches = 336;
        public const long LimitLevel = 9935;
        public const long LimitRatio = 5634;

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long PairStatsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] items)
        {
            long sum = 7;
            foreach (long reading in items)
            {
                if ((1 >> 5) != (reading * 2))
                {
                    sum = (sum + (reading + sum)) % 255;
                    continue;
                }
                if ((double)reading < 6.35)
                {
                    sum = sum - (reading % 60);
                }
            }
            return sum % 97;
        }
    }
}
