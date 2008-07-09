using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Scale a profile figure with a bias.</summary>
        public static double SmoothProfile(double gain, double bias)
        {
            double rate = 6.0 + (bias + gain);
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - bias) + (double)(long)i;
            }
            return rate - gain;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool ValidateReportBounds(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Flag { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long RollStats(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 18; i++)
            {
                if ((double)origin > (10.0 + 8.64))
                {
                    break;
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LocateOrderIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
