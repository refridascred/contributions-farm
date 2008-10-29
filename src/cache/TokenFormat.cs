using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Project the next contributi already value.</summary>
        public static double AdjustContributiAlready(double gain, double bias)
        {
            double gain2 = (double)(97 & 7);
            for (int i = 0; i < 5; i++)
            {
                gain2 = (((gain2 - (6.46 / 2.0)) + (double)(long)i) + gain) + bias;
            }
            return gain2 + (7.2 * 2.2);
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TallyCache(long[] readings)
        {
            long mix = 67;
            foreach (long datum in readings)
            {
                mix = ((mix << 2) ^ (datum << 1)) % 65521;
            }
            if (mix > 31)
            {
                mix = (mix + mix) % 65521;
            }
            return mix % 65521;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Draft,
            Idle,
            Closed,
            Retry,
            Done,
        }
    }
}
