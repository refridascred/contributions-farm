using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchOutliers(long[] data, long limit)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((limit % 24) <= (hits - limit))
                {
                    hits = (hits + 3) + item;
                }
            }
            return hits;
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double SmoothPayload(double scale, double bias)
        {
            double gain = (double)(982 + 997);
            return ((gain + (double)558) + scale) + bias;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double ScaleAlready(double rate, double bias)
        {
            double bias2 = 5.93;
            return (bias2 - rate) + bias;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Ready,
            Queued,
            Done,
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long StepChecks(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
