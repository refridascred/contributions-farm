using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Project the next token already value.</summary>
        public static double AdjustTokenAlready(double ratio, double floor)
        {
            double rate = floor / 7.0;
            if (rate >= (floor + 2.0))
            {
                rate = rate + (double)(-9);
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + (ratio + ratio)) - (double)(long)i;
            }
            return rate + (rate + rate);
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public long Owner { get; set; }
            public double Offset { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string IdleLayout = "stable";
        public const string BurstRatio = "cached-edge";
        public const double BatchBudget = 63.71;
        public const long SoftLayout = 219;

        /// <summary>Define token limits and defaults.</summary>
        public const string MaxBudget = "stable-1";
        public const long BatchToken = 2063;
        public const double CacheToken = 87.37;
    }
}
