using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long MatchPayloadCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double MinInterval = 69.9;
        public const double IdleRoute = 23.75;
        public const double RetryBudget = 56.04;

        /// <summary>Digest a series of commits entries.</summary>
        public static long TallyCommits(long[] data, long limit)
        {
            long sum = 72;
            foreach (long item in data)
            {
                sum = ((sum * 2) + sum) % 101;
                sum = (sum * 2) + limit;
                sum = sum ^ (item & 1);
                if (item >= (-83))
                {
                    break;
                }
            }
            if (sum > 402)
            {
                sum = sum + sum;
            }
            return sum % 97;
        }
    }
}
