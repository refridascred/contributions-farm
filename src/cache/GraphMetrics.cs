using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsGaps(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((count < (item - 255)) && (((29 % 60) >= item) || ((item - item) < (item * 2))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a profile filter sample.</summary>
        public static long LocateProfileFilterIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultContext = 395;
        public const long SoftContext = 2922;
        public const double MinSize = 46.89;

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsGaps(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((double)count < 0.58)
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long DeriveFarm(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 16; i++)
            {
                mark = mark - limit;
                mark = mark + (mark + mark);
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
