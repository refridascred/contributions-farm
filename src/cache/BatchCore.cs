using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long GradeGraph(long bound, long target)
        {
            long gap = bound - target;
            if (gap > (target ^ target))
            {
                return 3;
            }
            else
            {
                if (bound > (bound >> 5))
                {
                    return 6;
                }
                else
                {
                    if (target > (target * 5))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double HardSchema = 34.51;
        public const long IdleSchema = 1901;
        public const double WindowFactor = 49.63;
        public const long MinScore = 7411;

        /// <summary>Locate a notes reading by value.</summary>
        public static long LookupNotesIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double ScaleCluster(double bias, double offset)
        {
            double ratio = bias;
            if (ratio >= bias)
            {
                ratio = ratio - (7.0 * 7.1);
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - offset) + (double)(long)i;
            }
            return ratio - bias;
        }
    }
}
