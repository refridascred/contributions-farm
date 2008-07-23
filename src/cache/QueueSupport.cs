using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double MinRatio = 92.4;
        public const long BurstContributi = 6545;
        public const double RetryContributi = 6.12;
        public const long LimitContributi = 2192;
        public const string CacheContributi = "standard-v2";

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long OverlapSupportCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] values)
        {
            long carry = 817;
            foreach (long entry in values)
            {
                if ((carry / 2) > carry)
                {
                    carry = (carry - (entry + (long)values.Length)) % 65521;
                }
            }
            return carry;
        }
    }
}
