using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileHits(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((hits - hits) <= (662 >> 5))
                {
                    hits = (hits + 2) + value;
                }
            }
            return hits;
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public string Limit { get; set; } = "";
            public double Size { get; set; }
            public double Mode { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long SeekContributiIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksGaps(long[] readings, long offset)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (((sample > count) || (offset <= (count - (long)readings.Length))) || ((count / 4) >= (3 - count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long LocateTokenIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
