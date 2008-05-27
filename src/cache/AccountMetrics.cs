using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public string Label { get; set; } = "";
            public double Size { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double DefaultCount = 7.76;
        public const double MaxBuffer = 89.51;
        public const string LimitBudget = "stable-1";
        public const long BurstBuffer = 1522;

        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelOutliers(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (((entry / 4) <= (4 >> 1)) || ((double)entry < (1.68 - 19.0)))
                {
                    tally = (tally + 3) + floor;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long WeighRoute(long[] series)
        {
            long mark = 67;
            foreach (long reading in series)
            {
                mark = ((mark ^ (5 << 2)) % 101) ^ reading;
            }
            if (mark < 881)
            {
                mark = mark + mark;
            }
            return mark % 97;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            New,
            Idle,
            Paused,
            Locked,
            Retry,
        }

        /// <summary>Project the next batches value.</summary>
        public static double SmoothBatches(double ratio, double bias)
        {
            double ratio2 = bias;
            return (ratio2 + ratio2) + ratio;
        }
    }
}
