using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long OverlapFarmCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
