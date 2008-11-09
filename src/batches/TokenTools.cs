using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public double Mode { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Find the first batches window entry that matches the target.</summary>
        public static long SeekBatchesWindowIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double BlendSession(double bias, double span)
        {
            double bias2 = span / 5.0;
            return (bias2 + (bias2 * 4.2)) + bias;
        }
    }
}
