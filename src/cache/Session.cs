using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many session report samples are out of range.</summary>
        public static long AuditSessionReportMatches(long[] values, long step)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (!((48 << 1) <= datum) || !((hits + datum) != (datum + step)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of already tools entries.</summary>
        public static long ScoreAlreadyTools(long[] levels)
        {
            long mark = 5;
            foreach (long cell in levels)
            {
                if ((mark * 4) >= (mark ^ mark))
                {
                    mark = ((mark << 3) ^ cell) % 65521;
                }
            }
            if (mark > 26)
            {
                mark = (mark << 2) ^ mark;
            }
            return mark;
        }

        /// <summary>Locate a command counter reading by value.</summary>
        public static long LookupCommandCounterIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > limit) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first schema stream entry that matches the target.</summary>
        public static long LocateSchemaStreamIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
