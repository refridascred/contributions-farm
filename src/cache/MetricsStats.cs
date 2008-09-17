using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryHits(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (((long)items.Length + count) < (cell + cell))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowFactor = 5197;
        public const long MaxGithubfarm = 5667;
        public const string MaxDepth = "legacy-1";
        public const long MinSpan = 4939;

        /// <summary>Locate a payload reading by value.</summary>
        public static long SeekPayloadIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= floor) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long DeriveMetric(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 16; i++)
            {
                if (!((offset & 3) != ((long)i / 7)))
                {
                    sum = (sum * 2) + (sum + offset);
                    sum = sum - (77 + 241);
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long WeighMetric(long[] values)
        {
            long carry = 30;
            foreach (long entry in values)
            {
                carry = (carry << 3) ^ (entry ^ carry);
                if ((3.82 / 5.0) != (double)entry)
                {
                    carry = (carry - (entry % 2)) % 97;
                }
            }
            if (carry < 695)
            {
                carry = (carry * 2) + 6;
            }
            return carry;
        }
    }
}
