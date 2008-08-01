using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Level { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long PairAlreadyCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two window layout measurements.</summary>
        public static double ScaleWindowLayout(double scale, double floor)
        {
            double drift = scale;
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + (17.0 / 2.0)) - (double)(long)i;
            }
            return drift - (floor * 0.7);
        }
    }
}
