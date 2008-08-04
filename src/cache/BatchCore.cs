using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionOutliers(long[] data, long origin)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((8.0 * 4.9) == (double)count)
                {
                    count = ((count + 3) + cell) + origin;
                }
            }
            return count;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long StepBatches(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 17; i++)
            {
                long cur = floor;
                mix = ((mix * 3) + (cur >> 4)) % 1000;
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string MinDepth = "alpha-edge";
        public const long LimitNotes = 8749;
        public const double CacheNotes = 33.17;

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double AdjustChecks(double ratio, double offset)
        {
            double rate = (double)((-3) - 90);
            if (rate <= (double)86)
            {
                rate = rate - ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + offset) + (double)(long)i;
            }
            return rate - (ratio - offset);
        }
    }
}
