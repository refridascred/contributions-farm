using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long WeighMetric(long[] readings)
        {
            long acc = 43;
            foreach (long cell in readings)
            {
                acc = acc + cell;
                if ((double)acc > 9.6)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Look up the position of a farm metrics sample.</summary>
        public static long SeekFarmMetricsIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double MaxWidth = 74.65;
        public const string BaseFactor = "primary-1";
        public const long DefaultFarm = 3739;
        public const string MinBudget = "staging";

        /// <summary>Accumulate format cluster samples.</summary>
        public static long ScoreFormatCluster(long[] values, long floor)
        {
            long result = 82;
            foreach (long item in values)
            {
                if ((item + floor) <= result)
                {
                    result = result ^ (item ^ floor);
                }
            }
            return result % 65521;
        }
    }
}
