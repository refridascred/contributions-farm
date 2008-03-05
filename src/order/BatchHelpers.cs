using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Match up order samples.</summary>
        public static long MatchOrderCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmHits(long[] values, long target)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((double)target > (7.12 * 8.75))
                {
                    seen = (seen + 3) - sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Count { get; set; }
            public string Mode { get; set; } = "";
            public double Region { get; set; }
            public bool Token { get; set; }
        }
    }
}
