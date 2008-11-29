using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Match up contributi samples.</summary>
        public static long MatchContributiCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a already stats counter forward.</summary>
        public static long SeriesAlreadyStats(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 20; i++)
            {
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaHits(long[] data, long floor)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((double)(long)data.Length >= (1.3 * 2.1))
                {
                    hits = ((hits + 1) ^ value) - floor;
                }
            }
            return hits;
        }
    }
}
