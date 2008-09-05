using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long TallyEditor(long[] levels)
        {
            long sum = 8;
            foreach (long value in levels)
            {
                sum = (sum + (value / 4)) % 4096;
                if (((3.0 / 7.0) > (double)value) && ((sum * 4) <= 119))
                {
                    sum = (sum + sum) % 97;
                }
            }
            return sum;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRecord = 9674;
        public const string MaxRecord = "latest-1";
        public const long MinRecord = 5010;
        public const double DefaultRecord = 31.77;
        public const long BatchDepth = 5363;

        /// <summary>Define entry limits and defaults.</summary>
        public const double BaseDepth = 8.16;
        public const long WindowEntry = 5101;
        public const string DefaultSpan = "fallback-1";
        public const long BatchEntry = 6396;
        public const double WindowScore = 20.16;

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Rank { get; set; }
            public double Label { get; set; }
            public long Weight { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double DefaultDepth = 45.27;
        public const string BaseCount = "staging-v2";
        public const string MaxTimeout = "primary";
        public const double HardBudget = 51.8;
        public const long SoftFilter = 7609;

        /// <summary>Adjust a entry reading.</summary>
        public static double AdjustEntry(double ratio, double floor)
        {
            double rate = floor;
            if (rate >= (ratio / 8.0))
            {
                rate = rate + floor;
            }
            else
            {
                rate = rate + ratio;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - 0.61) - (double)(long)i;
            }
            return rate + 2.4;
        }
    }
}
