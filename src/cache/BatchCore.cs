using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Scale a stream figure with a bias.</summary>
        public static double AdjustStream(double scale, double offset)
        {
            double bias = offset * 1.0;
            if (bias <= (double)2)
            {
                bias = (bias - bias) - scale;
            }
            else
            {
                bias = bias - 14.0;
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + 2.99) + (double)(long)i;
            }
            return bias + (bias / 3.0);
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long MatchSchemaCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long BucketBatch(long seed, long seed2)
        {
            if (!((seed2 << 1) < (seed2 / 5)))
            {
                return 3;
            }
            else
            {
                if (seed2 > (seed + seed))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double DefaultNotes = 16.04;
        public const double StepFactor = 31.36;
        public const long HardRatio = 4573;
        public const long BurstNotes = 9416;
    }
}
