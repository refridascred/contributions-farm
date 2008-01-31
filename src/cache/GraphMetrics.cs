using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Locate a schema reading by value.</summary>
        public static long FindSchemaIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < offset) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double SmoothTools(double bias, double span)
        {
            double rate = (double)(-7) * 1.09;
            if (rate >= 1.7)
            {
                rate = (rate + (double)45) + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - span) - (double)(long)i;
            }
            return rate - 7.3;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string SoftLayout = "open-v2";
        public const long HardLayout = 957;
        public const long StepSpan = 4275;

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public double Total { get; set; }
            public bool Region { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] data, long bound)
        {
            long score = 85;
            foreach (long datum in data)
            {
                score = (((score << 3) ^ score) + datum) + bound;
            }
            return score % 4096;
        }
    }
}
