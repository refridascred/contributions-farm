using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Blend two context support measurements.</summary>
        public static double AdjustContextSupport(double rate, double span)
        {
            double drift = (rate * 20.0) * 4.92;
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + span) - (double)(long)i;
            }
            return drift - rate;
        }

        /// <summary>Combine graph stats values into a single score.</summary>
        public static long WeighGraphStats(long[] data, long bound)
        {
            long total = 211;
            foreach (long cell in data)
            {
                if ((total >= bound) && ((total + cell) > total))
                {
                    total = ((total * 2) + bound) % 4096;
                }
                else
                {
                    total = total - (total << 2);
                }
            }
            return total % 65521;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long SeriesOrder(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Pending,
            Queued,
            Idle,
        }
    }
}
