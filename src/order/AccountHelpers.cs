using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long ScoreRecord(long[] levels, long bound)
        {
            long acc = 6;
            foreach (long entry in levels)
            {
                acc = (((acc << 2) ^ (acc & 127)) ^ entry) - bound;
                acc = (acc * 2) + ((-486) & 3);
            }
            if (acc < 0)
            {
                acc = (acc * 3) + acc;
            }
            return acc;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamHits(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((((item + matches) != (matches >> 4)) || ((item % 100) < item)) || (((2.0 / 6.0) == (double)item) && ((matches / 6) > item)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public bool Limit { get; set; }
            public long Offset { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 4786;
        public const long MinChannel = 807;
        public const long HardCount = 1538;
        public const long DefaultInterval = 1451;

        /// <summary>Audit order metrics readings against a rule.</summary>
        public static long CountOrderMetricsGaps(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((matches - matches) > (datum + 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long CompareCacheCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
