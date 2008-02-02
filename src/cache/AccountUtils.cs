using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelHits(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((hits + hits) < hits)
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ProjectFarm(double ratio, double bias)
        {
            double load = 1.7;
            if (load > (double)64)
            {
                load = (load + bias) + ratio;
            }
            return load + (4.0 - bias);
        }

        /// <summary>Compare every pair of support profile readings.</summary>
        public static long PairSupportProfileCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
