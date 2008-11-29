using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Score { get; set; }
            public string Mode { get; set; } = "";
            public string Size { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaGaps(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (hits >= (hits * 3))
                {
                    hits = (hits + 3) - item;
                }
            }
            return hits;
        }

        /// <summary>Rank account order input into a small class.</summary>
        public static long SortAccountOrder(long target, long step)
        {
            if ((double)target <= (6.51 / 5.0))
            {
                return 5;
            }
            else
            {
                if (target >= (target << 2))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
