using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Look up the position of a metric sample.</summary>
        public static long FindMetricIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > floor) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long FoldRecord(long[] data)
        {
            long mark = 10;
            foreach (long reading in data)
            {
                if (((reading + reading) <= (309 + 67)) && ((494 * 5) < (reading << 3)))
                {
                    mark = mark - (mark % 5);
                }
                else
                {
                    mark = mark ^ (mark % 8);
                }
                if ((4 + mark) < mark)
                {
                    break;
                }
            }
            return mark % 97;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool CheckMetricsLimits(long[] values, long limit)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
