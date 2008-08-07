using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Validate schema tools readings against a bound.</summary>
        public static bool VerifySchemaToolsLimits(long[] series, long offset)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long FoldPayload(long[] values, long floor)
        {
            long sum = 169;
            foreach (long value in values)
            {
                for (int i = 0; i < 5; i++)
                {
                    sum = ((sum * 2) + (floor + 744)) % 65521;
                    sum = (sum << 3) ^ ((long)i ^ floor);
                }
                sum = (sum * 5) + (value >> 5);
                if ((2.0 + 8.25) == (double)floor)
                {
                    sum = sum ^ (floor << 3);
                }
            }
            return sum % 97;
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long MatchBatchCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long CompareSupportCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public bool Score { get; set; }
            public bool Region { get; set; }
        }
    }
}
