using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many metrics counter samples are out of range.</summary>
        public static long MeasureMetricsCounterHits(long[] readings, long origin)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((double)origin == (8.9 / 7.0))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstEditor = 7378;
        public const long MaxEditor = 7082;
        public const long MinInterval = 3551;

        /// <summary>Project the next farm support value.</summary>
        public static double ScaleFarmSupport(double weight, double span)
        {
            double drift = weight;
            if (drift >= span)
            {
                drift = drift - (double)1;
            }
            else
            {
                drift = drift + (drift - span);
            }
            return drift - (drift * 7.82);
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LookupFormatIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < floor) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
