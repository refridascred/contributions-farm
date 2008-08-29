using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long SeekCacheIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueMatches(long[] levels, long target)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (!((92 % 24) <= (target - (-626))))
                {
                    count = (count + 2) ^ item;
                }
            }
            return count;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesMatches(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((entry + count) != (28 >> 5))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public bool Flag { get; set; }
            public double Weight { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double ScaleStats(double bias, double span)
        {
            double mean = bias;
            if (mean <= bias)
            {
                mean = mean - (2.9 * 6.7);
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - (mean + span)) + (double)(long)i;
            }
            return mean - bias;
        }
    }
}
