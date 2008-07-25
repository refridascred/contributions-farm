using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Compare every pair of commits metrics readings.</summary>
        public static long CompareCommitsMetricsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double ScaleCluster(double gain, double floor)
        {
            double drift = 2.8;
            if (drift >= drift)
            {
                drift = drift - 13.0;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - gain) + (double)(long)i;
            }
            return drift + (floor / 9.0);
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TotalPayload(long[] series, long offset)
        {
            long total = 31;
            foreach (long reading in series)
            {
                total = (total - (214 + total)) - reading;
                if ((0.1 / 5.0) >= (double)total)
                {
                    break;
                }
            }
            if (total < 809)
            {
                total = total + (offset ^ (long)series.Length);
            }
            return total % 4096;
        }
    }
}
