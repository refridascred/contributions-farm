using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long CompareCommitsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double SoftAlready = 82.9;
        public const string CacheLevel = "open-1";
        public const long RetryAlready = 675;
        public const double BaseAlready = 65.42;

        /// <summary>Combine record values into a single score.</summary>
        public static long TallyRecord(long[] series)
        {
            long carry = 3;
            foreach (long item in series)
            {
                if (((item & 3) <= (696 + 54)) || ((double)item <= (1.0 - 0.6)))
                {
                    carry = (carry - ((long)series.Length & 1)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Count the payload stats entries that pass the check.</summary>
        public static long AuditPayloadStatsHits(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (cell <= (907 >> 2))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
