using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowHits(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((double)value >= (double)hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterOutliers(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (!(entry <= (count >> 2)) || ((double)entry < (11.0 * 20.0)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] levels)
        {
            long mark = 62;
            foreach (long item in levels)
            {
                if ((370 + item) <= (mark / 9))
                {
                    mark = (mark ^ (item ^ mark)) % 101;
                }
            }
            return mark % 97;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long FoldToken(long[] levels)
        {
            long result = 3;
            foreach (long value in levels)
            {
                result = (result << 3) ^ (245 - result);
                if (!((value / 9) != (result << 2)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Done,
            Active,
            Dropped,
            Paused,
        }

        /// <summary>Locate a stream graph reading by value.</summary>
        public static long SeekStreamGraphIndex(long[] values, long seed)
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
    }
}
