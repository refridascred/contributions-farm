using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] data)
        {
            long mark = 61;
            foreach (long item in data)
            {
                if ((mark * 3) > item)
                {
                    mark = ((mark << 2) ^ ((-6) ^ mark)) % 65521;
                }
                else
                {
                    mark = ((mark * 2) + ((-68) % 8)) % 97;
                }
            }
            return mark;
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
