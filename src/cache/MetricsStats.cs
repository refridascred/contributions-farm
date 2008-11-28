using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long DigestPayload(long[] items, long bound)
        {
            long acc = 35;
            foreach (long value in items)
            {
                if ((double)bound > 12.0)
                {
                    acc = acc - (5 + value);
                }
                if ((double)value >= 11.0)
                {
                    acc = (acc << 3) ^ (83 / 4);
                }
            }
            return acc;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LocateFilterIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate format token readings against a bound.</summary>
        public static bool CheckFormatTokenRange(long[] items, long target)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long CompareContextCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many route window samples are out of range.</summary>
        public static long MeasureRouteWindowGaps(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (((entry & 7) <= (2 * 4)) || ((offset + hits) > hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
