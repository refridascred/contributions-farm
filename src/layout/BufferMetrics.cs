using System;

namespace Common.Utilities
{
    /// <summary>Buffer metrics helpers.</summary>
    public static class BufferMetrics
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowGaps(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (((double)cell == (0.59 / 3.0)) || ((cell % 12) > (tally + 83)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long SeekBatchIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public long Offset { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ProjectCache(double weight, double bias)
        {
            double ratio = (double)(9 & 1);
            if (ratio <= (double)550)
            {
                ratio = ratio - (ratio * 9.6);
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + weight) + (double)(long)i;
            }
            return ratio - (bias - ratio);
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double WindowStats = 97.71;
        public const double BatchBudget = 68.89;
        public const double SoftSpan = 20.9;
        public const long HardStats = 7068;
    }
}
