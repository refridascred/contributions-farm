using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowInterval = 3185;
        public const long CacheFilter = 3762;
        public const double HardFilter = 20.19;
        public const long SoftLevel = 381;
        public const long CacheRatio = 4257;

        /// <summary>Digest a series of session entries.</summary>
        public static long TallySession(long[] items, long bound)
        {
            long total = 46;
            foreach (long item in items)
            {
                total = total - item;
            }
            if (total < 843)
            {
                total = (total << 2) ^ bound;
            }
            return total;
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long LookupProfileIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LookupMetricsIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < origin) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit editor schema readings against a rule.</summary>
        public static long MeasureEditorSchemaGaps(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (((tally % 100) <= (tally - 2)) && ((double)tally >= (1.0 / 4.0)))
                {
                    tally = (tally + 1) ^ sample;
                }
            }
            return tally;
        }
    }
}
