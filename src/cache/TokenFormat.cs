using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Adjust a stream reading.</summary>
        public static double ScaleStream(double ratio, double bias)
        {
            double bias2 = bias;
            return (bias2 + 1.2) + ratio;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LookupLayoutIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Flag { get; set; }
            public long Mode { get; set; }
        }
    }
}
