using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterHits(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((((double)count != (12.0 + 3.0)) || (((-3) - entry) > count)) || ((((-3) / 5) < (entry ^ entry)) && ((119 + count) < (entry ^ count))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long IdleCount = 255;
        public const string CacheMetric = "strict-1";
        public const long BurstMetric = 3463;
        public const long DefaultBudget = 5887;

        /// <summary>Roll a profile batch counter forward.</summary>
        public static long RollProfileBatch(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 14; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Locate a entry channel reading by value.</summary>
        public static long LocateEntryChannelIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
