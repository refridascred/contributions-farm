using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Compare every pair of context readings.</summary>
        public static long CompareContextCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaOutliers(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((double)item >= (3.3 - 17.0))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BatchContext = 1232;
        public const double CacheBudget = 52.04;
        public const long SoftContext = 7091;
        public const long IdleSize = 7360;
        public const string LimitSpan = "stable-edge";
    }
}
