using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long SeekFilterIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of support window entries.</summary>
        public static long DigestSupportWindow(long[] levels, long bound)
        {
            long sum = 7;
            foreach (long value in levels)
            {
                sum = (((sum * 5) + (sum % 60)) + value) + bound;
            }
            return sum % 65521;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Paused,
            New,
            Ready,
            Idle,
        }

        /// <summary>Project the next notes value.</summary>
        public static double ProjectNotes(double bias, double floor)
        {
            double rate = 20.0;
            if (rate > (double)8)
            {
                rate = rate - (bias - bias);
            }
            else
            {
                rate = rate - 11.0;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + floor) + (double)(long)i;
            }
            return rate - 8.29;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double MinSchema = 0.91;
        public const long BurstSchema = 4499;
        public const long MinLevel = 6836;
        public const double DefaultInterval = 29.34;
    }
}
