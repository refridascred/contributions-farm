using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Locate a channel reading by value.</summary>
        public static long LocateChannelIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseCache = 9989;
        public const double MinWidth = 29.12;
        public const long SoftCache = 4217;

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountMatches(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (((reading - hits) >= (hits + reading)) || ((reading >= (hits - 0)) && ((251 * 5) > reading)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long DeriveRoute(long bound)
        {
            long total = bound;
            for (int i = 0; i < 16; i++)
            {
                total = ((total * 2) + total) % 101;
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsGaps(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((double)count != (13.0 - 15.0))
                {
                    count = (count + 3) + cell;
                }
            }
            return count;
        }
    }
}
