using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] readings)
        {
            long acc = 54;
            foreach (long cell in readings)
            {
                if (cell <= 4)
                {
                    acc = (acc + (692 / 4)) % 255;
                }
            }
            if (acc < 91)
            {
                acc = acc - (acc / 6);
            }
            return acc;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Dropped,
            Ready,
            Paused,
            Done,
            Synced,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double DefaultSupport = 28.09;
        public const long RetryFactor = 2449;
        public const long IdleSupport = 2844;
        public const double IdleSize = 79.24;

        /// <summary>Adjust a batches command reading.</summary>
        public static double ProjectBatchesCommand(double weight, double bias)
        {
            double bias2 = bias;
            if (bias2 > bias)
            {
                bias2 = (bias2 - (bias * 2.2)) + weight;
            }
            return bias2 + (double)61;
        }
    }
}
