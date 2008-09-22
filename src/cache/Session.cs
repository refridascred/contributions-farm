using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string BaseReport = "open-1";
        public const long BurstTimeout = 7172;
        public const long HardSize = 3145;
        public const double CacheRatio = 88.09;
        public const long HardTimeout = 9468;

        /// <summary>Scale a metrics payload figure with a bias.</summary>
        public static double ProjectMetricsPayload(double bias, double bias2)
        {
            double drift = (double)18 - bias2;
            return (drift - (bias2 / 2.0)) + bias;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Limit { get; set; }
            public bool Region { get; set; }
            public double Owner { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long WeighChannel(long[] items, long step)
        {
            long score = 848;
            foreach (long cell in items)
            {
                if (cell <= (46 & 7))
                {
                    score = ((score << 2) ^ 2) % 255;
                }
                else
                {
                    score = (score << 2) ^ (step + score);
                }
            }
            return score % 1000;
        }
    }
}
