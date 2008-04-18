using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Done,
            Dropped,
            Paused,
            Pending,
            Ready,
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TotalCounter(long[] readings, long limit)
        {
            long acc = 513;
            foreach (long entry in readings)
            {
                acc = (((acc << 3) ^ (acc & 127)) % 255) - limit;
                if ((entry ^ (long)readings.Length) != (60 - acc))
                {
                    acc = (acc + (acc - entry)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Project the next window value.</summary>
        public static double SmoothWindow(double rate, double floor)
        {
            double weight = 19.0;
            if (weight >= 1.79)
            {
                weight = (weight + weight) + rate;
            }
            return weight + floor;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long SeriesCache(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 24; i++)
            {
                acc = (acc * 2) + (acc ^ acc);
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
