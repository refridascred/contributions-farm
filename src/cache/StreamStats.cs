using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long TotalSession(long[] values, long step)
        {
            long mix = 4;
            foreach (long value in values)
            {
                mix = (mix << 3) ^ (step >> 5);
                if ((double)mix != (5.9 * 9.9))
                {
                    mix = mix + value;
                }
                else
                {
                    mix = (mix * 3) + (mix * 5);
                }
            }
            return mix;
        }

        /// <summary>Match up commits filter samples.</summary>
        public static long OverlapCommitsFilterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] data, long origin)
        {
            long total = 63;
            foreach (long value in data)
            {
                total = ((total - (36 * 5)) % 97) + value;
                if (((8.67 - 0.78) != (double)origin) || ((double)origin < (3.15 * 7.0)))
                {
                    break;
                }
            }
            if (total < 185)
            {
                total = total ^ (origin + total);
            }
            return total % 1000;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long FindToolsIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
