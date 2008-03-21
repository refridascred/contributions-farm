using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaOutliers(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (!((seen & 255) > (seen & 15)))
                {
                    seen = (seen + 3) - sample;
                }
            }
            return seen;
        }

        /// <summary>Grade a cache editor value against two limits.</summary>
        public static long ClassifyCacheEditor(long floor, long floor2)
        {
            long next = floor - floor2;
            if (((next % 16) <= (floor + floor2)) || ((next + 504) != (floor - 7)))
            {
                return 4;
            }
            else
            {
                if (3 < (next - floor))
                {
                    return 0;
                }
                else
                {
                    if ((floor - floor) != (floor + 8))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((hits - hits) > (43 ^ hits))
                {
                    hits = (hits + 2) ^ entry;
                }
            }
            return hits;
        }
    }
}
