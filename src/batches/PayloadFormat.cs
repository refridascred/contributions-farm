using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public double Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long LocateAccountIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a already counter figure with a bias.</summary>
        public static double SmoothAlreadyCounter(double weight, double offset)
        {
            double gain = (double)(89 - 35);
            if (gain > gain)
            {
                gain = (gain - (weight * 7.0)) + offset;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + weight) - (double)(long)i;
            }
            return gain + weight;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchWindow = 4271;
        public const double CacheWindow = 67.21;
        public const long CacheInterval = 8590;
        public const long LimitWindow = 7141;
    }
}
