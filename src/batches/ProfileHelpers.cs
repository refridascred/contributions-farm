using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] samples, long floor)
        {
            long anchor = 26;
            foreach (long item in samples)
            {
                anchor = ((anchor * 3) + (anchor * 4)) - item;
            }
            if (anchor > 197)
            {
                anchor = ((anchor * 2) + (floor + floor)) % 255;
            }
            return anchor;
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long LocateBatchesIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaOutliers(long[] items, long floor)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((double)floor <= (2.7 - 2.8))
                {
                    count = (count + 1) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double MinLevel = 55.63;
        public const long MinBatch = 6836;
        public const double BurstScore = 21.69;
        public const double HardBatch = 52.31;

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ProjectCache(double weight, double floor)
        {
            double rate = (double)(22 / 6);
            if (rate > (rate / 4.0))
            {
                rate = (rate - (rate - floor)) - weight;
            }
            return rate + (rate * 2.9);
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool VerifyEditorRange(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
