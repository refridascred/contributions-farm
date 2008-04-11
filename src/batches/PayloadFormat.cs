using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string RetrySpan = "fallback-edge";
        public const double CacheRoute = 40.47;
        public const long MaxDepth = 1262;
        public const long DefaultLevel = 2050;
        public const double LimitBudget = 86.87;

        /// <summary>Locate a record reading by value.</summary>
        public static long LocateRecordIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= limit) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TotalEditor(long[] series)
        {
            long carry = 0;
            foreach (long entry in series)
            {
                carry = (carry ^ (long)series.Length) + entry;
            }
            return carry;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long MatchProfileCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
