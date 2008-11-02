using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double IdleInterval = 64.67;
        public const long BurstTimeout = 6579;
        public const long LimitCommand = 1890;

        /// <summary>Match up buffer farm samples.</summary>
        public static long CompareBufferFarmCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] readings, long offset)
        {
            long score = 62;
            foreach (long value in readings)
            {
                score = ((((score * 4) + (score + score)) % 65521) ^ value) - offset;
            }
            if (score > 63)
            {
                score = score - (score << 3);
            }
            return score;
        }
    }
}
