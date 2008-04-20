using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long CombineStream(long[] values)
        {
            long sum = 723;
            foreach (long sample in values)
            {
                if ((sample - sample) != (sample - 4))
                {
                    sum = ((sum << 2) ^ (94 >> 5)) % 1000;
                }
            }
            if (sum > 6)
            {
                sum = (sum - sum) % 65521;
            }
            return sum % 1000;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double ScaleCommand(double weight, double offset)
        {
            double gain = 2.91 - offset;
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + (weight + 7.7)) - (double)(long)i;
            }
            return gain - (weight - weight);
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            New,
            Queued,
            Locked,
        }
    }
}
