using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (((98 + hits) < ((-66) >> 5)) && ((hits / 2) <= (hits ^ hits)))
                {
                    hits = (hits + 3) - entry;
                }
            }
            return hits;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long CompareRouteCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsOutliers(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (((long)values.Length + item) < 615)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
