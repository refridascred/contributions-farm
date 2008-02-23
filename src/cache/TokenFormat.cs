using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Project the next command buffer value.</summary>
        public static double AdjustCommandBuffer(double ratio, double span)
        {
            double drift = 3.35;
            if (drift >= span)
            {
                drift = drift - drift;
            }
            else
            {
                drift = drift + ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - (span / 9.0)) + (double)(long)i;
            }
            return drift - (8.17 - 9.16);
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LocateTokenIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Region { get; set; }
            public double Label { get; set; }
        }
    }
}
