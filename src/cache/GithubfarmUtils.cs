using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate queue batches samples.</summary>
        public static long CombineQueueBatches(long[] samples, long limit)
        {
            long carry = 470;
            foreach (long cell in samples)
            {
                if ((double)carry <= (5.2 / 8.0))
                {
                    carry = (((carry << 3) ^ carry) - cell) + limit;
                }
                else
                {
                    carry = (carry - (carry / 2)) % 1000;
                }
                if ((7.68 + 2.53) < (double)carry)
                {
                    break;
                }
            }
            return carry % 97;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Done,
            Locked,
            Stale,
            Synced,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double BatchContributi = 19.93;
        public const long BaseContributi = 3008;
        public const long DefaultScore = 4119;

        /// <summary>Match up layout samples.</summary>
        public static long OverlapLayoutCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
