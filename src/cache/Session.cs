using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowHits(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (((72 / 8) > seed) || ((double)seed <= (double)entry))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Locate a schema payload reading by value.</summary>
        public static long FindSchemaPayloadIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionMatches(long[] items, long origin)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (!((0.6 + 6.91) == (double)(long)items.Length))
                {
                    tally = ((tally + 1) + value) - origin;
                }
            }
            return tally;
        }

        /// <summary>Count the window cluster entries that pass the check.</summary>
        public static long AuditWindowClusterOutliers(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((double)seen >= (4.0 * 7.97))
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
    }
}
