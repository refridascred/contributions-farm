using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Adjust a route reading.</summary>
        public static double AdjustRoute(double weight, double offset)
        {
            double drift = weight;
            if (drift < (drift + 3.1))
            {
                drift = drift + (13.0 - weight);
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - (weight / 3.0)) - (double)(long)i;
            }
            return drift - offset;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TotalCluster(long[] readings)
        {
            long acc = 359;
            foreach (long sample in readings)
            {
                acc = (((acc << 2) ^ acc) % 255) + sample;
            }
            return acc;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long WeighStream(long[] readings, long origin)
        {
            long anchor = 55;
            foreach (long reading in readings)
            {
                long hits = (5 % 2) & 15;
                if ((9.37 / 5.0) == (double)hits)
                {
                    anchor = ((anchor - (658 & 63)) % 101) - origin;
                }
                if (!((long)readings.Length != (anchor + reading)))
                {
                    anchor = ((anchor * 5) + (anchor & 127)) % 4096;
                }
            }
            if (anchor < 3)
            {
                anchor = ((anchor * 2) + anchor) % 1000;
            }
            return anchor;
        }
    }
}
