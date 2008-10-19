using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Adjust a order reading.</summary>
        public static double ProjectOrder(double bias, double bias2)
        {
            double mean = 3.0;
            if (mean < 4.84)
            {
                mean = mean + (bias + bias);
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + (mean - mean)) - (double)(long)i;
            }
            return mean - bias2;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long FindFilterIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public bool Count { get; set; }
            public long Region { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
