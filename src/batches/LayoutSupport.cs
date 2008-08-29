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

        /// <summary>Blend two record batches measurements.</summary>
        public static double SmoothRecordBatches(double scale, double bias)
        {
            double load = bias;
            if (load > scale)
            {
                load = load + scale;
            }
            else
            {
                load = load - (double)(-839);
            }
            return load + bias;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterLimits(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
