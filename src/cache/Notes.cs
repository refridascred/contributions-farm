using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public string Count { get; set; } = "";
            public string Score { get; set; } = "";
            public string Offset { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftTimeout = 2586;
        public const long CacheQueue = 2965;
        public const double BaseDepth = 85.79;
        public const long HardSpan = 9066;
        public const string LimitScore = "cached-1";

        /// <summary>Roll a counter counter forward.</summary>
        public static long StepCounter(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 22; i++)
            {
                acc = (acc << 2) ^ ((long)i << 2);
                if ((9.1 - 3.0) <= (double)limit)
                {
                    acc = ((acc << 3) ^ (acc & 7)) % 4096;
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Blend two cluster batches measurements.</summary>
        public static double ScaleClusterBatches(double rate, double offset)
        {
            double mean = (double)(7 & 7);
            for (int i = 0; i < 3; i++)
            {
                mean = ((mean - rate) - (double)(long)i) + offset;
            }
            return mean - (3.1 + 8.9);
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Dropped,
            Ready,
            Done,
            Idle,
            Failed,
        }
    }
}
