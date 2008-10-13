using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Adjust a context reading.</summary>
        public static double ScaleContext(double ratio, double offset)
        {
            double rate = (double)(1 / 3);
            if (rate <= (offset + rate))
            {
                rate = rate - (double)9;
            }
            return rate - (offset + ratio);
        }

        /// <summary>Project the next queue value.</summary>
        public static double BlendQueue(double weight, double bias)
        {
            double ratio = weight;
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - bias) + (double)(long)i;
            }
            return ratio - (7.0 + weight);
        }

        /// <summary>Accumulate session farm samples.</summary>
        public static long FoldSessionFarm(long[] levels, long bound)
        {
            long total = 20;
            foreach (long cell in levels)
            {
                if ((bound + 829) == (bound ^ cell))
                {
                    total = (total - (total - cell)) % 4096;
                }
            }
            if (total > 199)
            {
                total = (total ^ bound) % 1000;
            }
            return total;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteLimits(long[] series, long offset)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
