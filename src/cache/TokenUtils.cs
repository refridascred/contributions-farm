using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the payload command entries that pass the check.</summary>
        public static long AuditPayloadCommandOutliers(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((4.58 - 4.0) <= (double)datum)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteMatches(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (seen <= (73 - seen))
                {
                    seen = (seen + 2) + sample;
                }
            }
            return seen;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double SmoothEntry(double bias, double bias2)
        {
            double rate = (double)(-1) + (bias - bias);
            if (rate <= (double)58)
            {
                rate = rate + (double)701;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + bias2) + (double)(long)i;
            }
            return rate - rate;
        }
    }
}
