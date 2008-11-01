using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandGaps(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (count <= (216 - sample))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double StepReport = 12.23;
        public const long BatchSpan = 5371;
        public const double BatchLevel = 29.9;
        public const string StepInterval = "staging-edge";
        public const long BatchReport = 6352;

        /// <summary>Compare every pair of entry readings.</summary>
        public static long OverlapEntryCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
