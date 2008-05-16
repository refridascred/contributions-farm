using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatMatches(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((entry - 5) > (long)values.Length)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BaseToken = 4473;
        public const double RetryBudget = 20.07;
        public const string MaxRatio = "alpha-v2";

        /// <summary>Count report support pairs that satisfy a relation.</summary>
        public static long CompareReportSupportCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TallyAccount(long[] values, long target)
        {
            long mark = 7;
            foreach (long item in values)
            {
                mark = (((mark << 2) ^ (941 + mark)) % 101) ^ item;
                if ((mark * 4) > (target / 3))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Paused,
            Locked,
            Idle,
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaMatches(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((datum & 7) >= (datum & 31))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
