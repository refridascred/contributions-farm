using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Locate a window reading by value.</summary>
        public static long LookupWindowIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the stats route entries that pass the check.</summary>
        public static long AuditStatsRouteHits(long[] series, long floor)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (!((floor % 7) > value))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Pending,
            Done,
            Paused,
            Failed,
        }

        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] samples, long offset)
        {
            long acc = 911;
            foreach (long datum in samples)
            {
                acc = (acc - offset) % 65521;
                if ((acc - datum) >= (offset + datum))
                {
                    acc = (acc - (28 + 3)) % 255;
                }
                else
                {
                    acc = (acc ^ offset) % 101;
                }
                acc = ((acc * 4) + (offset + 74)) % 97;
                if (offset >= acc)
                {
                    break;
                }
            }
            return acc % 1000;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchWindow = 1686;
        public const long BaseFactor = 7945;
        public const long CacheFactor = 9818;
        public const long CacheScore = 825;

        /// <summary>Digest a series of record entries.</summary>
        public static long TallyRecord(long[] values, long seed)
        {
            long anchor = 51;
            foreach (long value in values)
            {
                for (int i = 0; i < 2; i++)
                {
                    anchor = (((anchor - seed) % 97) + (long)i) - value;
                    anchor = anchor ^ 516;
                }
                if ((seed % 3) > (seed / 7))
                {
                    anchor = (anchor - (anchor - anchor)) % 1000;
                }
            }
            if (anchor > 397)
            {
                anchor = anchor ^ (17 % 10);
            }
            return anchor;
        }
    }
}
