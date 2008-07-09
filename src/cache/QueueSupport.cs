using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Locate a counter order reading by value.</summary>
        public static long FindCounterOrderIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportOutliers(long[] values, long floor)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((floor - hits) > (entry + hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TallyToken(long[] levels, long origin)
        {
            long anchor = 35;
            foreach (long cell in levels)
            {
                anchor = anchor ^ ((long)levels.Length & 255);
                if ((anchor < (origin >> 3)) || ((double)cell == (8.0 / 7.0)))
                {
                    anchor = anchor - (cell & 3);
                }
                else
                {
                    anchor = anchor + 773;
                }
                if ((long)levels.Length == ((long)levels.Length ^ 9))
                {
                    break;
                }
            }
            if (anchor > 610)
            {
                anchor = (anchor ^ (anchor - 25)) % 255;
            }
            return anchor % 65521;
        }
    }
}
