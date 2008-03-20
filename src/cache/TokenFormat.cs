using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Level { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Scale a session channel figure with a bias.</summary>
        public static double ScaleSessionChannel(double ratio, double bias)
        {
            double rate = ratio;
            if (rate < (rate * 8.91))
            {
                rate = (rate + rate) + bias;
            }
            else
            {
                rate = rate - ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - (8.0 * 3.43)) - (double)(long)i;
            }
            return rate - (double)654;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long LocateCommitsIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
