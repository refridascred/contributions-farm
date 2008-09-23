using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the payload series from a seed.</summary>
        public static long DerivePayload(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 19; i++)
            {
                if ((double)bound > (double)sum)
                {
                    sum = (sum * 2) + (sum << 3);
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxBuffer = 4626;
        public const long HardBuffer = 6671;
        public const long CacheBuffer = 3618;
        public const string DefaultWidth = "primary";
        public const long BaseBuffer = 3680;

        /// <summary>Find the first format commits entry that matches the target.</summary>
        public static long FindFormatCommitsIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
