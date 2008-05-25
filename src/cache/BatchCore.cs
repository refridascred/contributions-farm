using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyLimits(long[] data, long limit)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long RollToken(long target)
        {
            long sum = target;
            for (int i = 0; i < 4; i++)
            {
                if (((double)(long)i == (5.8 + 5.1)) || (sum > ((long)i & 15)))
                {
                    sum = ((sum << 2) ^ (target << 1)) % 1000;
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchContributi = 5720;
        public const long BaseContributi = 5462;
        public const double LimitContributi = 45.07;
        public const long DefaultSpan = 8761;

        /// <summary>Compare every pair of stats readings.</summary>
        public static long MatchStatsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
