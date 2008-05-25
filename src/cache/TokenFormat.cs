using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Project the next cluster value.</summary>
        public static double ScaleCluster(double scale, double floor)
        {
            double scale2 = (double)4 + scale;
            if (scale2 > (scale2 + floor))
            {
                scale2 = scale2 + (6.0 + 9.3);
            }
            for (int i = 0; i < 6; i++)
            {
                scale2 = (scale2 - scale) + (double)(long)i;
            }
            return scale2 - (scale / 5.0);
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextOutliers(long[] values, long step)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((value + value) < (step * 4))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long OverlapCounterCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
