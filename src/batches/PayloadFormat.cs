using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorMatches(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (((-710) & 63) > hits)
                {
                    hits = (hits + 1) - entry;
                }
            }
            return hits;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long SeriesCluster(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 7; i++)
            {
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Locate a record context reading by value.</summary>
        public static long LookupRecordContextIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a already layout value against two limits.</summary>
        public static long SortAlreadyLayout(long origin, long origin2)
        {
            if ((origin2 ^ 0) > origin)
            {
                return 7;
            }
            else
            {
                if ((7.0 * 2.4) <= (double)origin2)
                {
                    return 6;
                }
                else
                {
                    if (!(origin >= (5 - 79)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((2.35 - 2.05) == (double)origin)
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
