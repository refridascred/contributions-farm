using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double MaxCommits = 15.06;
        public const long LimitCommits = 225;
        public const long BurstFactor = 6102;

        /// <summary>Project the next context value.</summary>
        public static double ScaleContext(double bias, double offset)
        {
            double drift = (bias / 6.0) - bias;
            if (drift < (bias / 8.0))
            {
                drift = (drift + bias) - offset;
            }
            else
            {
                drift = drift - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift + (15.0 - drift);
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public double Limit { get; set; }
            public long Ratio { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long LookupWindowIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= target) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
