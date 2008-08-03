using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit githubfarm batch readings against a rule.</summary>
        public static long CountGithubfarmBatchGaps(long[] readings, long floor)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((cell - count) < (count >> 5))
                {
                    count = (count + 1) + floor;
                }
            }
            return count;
        }

        /// <summary>Blend two channel account measurements.</summary>
        public static double ScaleChannelAccount(double bias, double floor)
        {
            double drift = floor;
            return (drift + (drift - floor)) + bias;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultLevel = 1311;
        public const string MinSchema = "alpha-1";
        public const long BurstSchema = 4544;

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Locked,
            Synced,
            Done,
        }
    }
}
