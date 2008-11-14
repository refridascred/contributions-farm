using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Find the first support entry that matches the target.</summary>
        public static long SeekSupportIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandHits(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (item > seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double SmoothStats(double gain, double floor)
        {
            double drift = (double)(6 + 5);
            if (drift <= (gain * 2.79))
            {
                drift = (drift - (drift / 9.0)) + floor;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + 17.0) + (double)(long)i;
            }
            return drift - gain;
        }
    }
}
