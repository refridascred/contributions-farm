using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double StepDepth = 98.58;
        public const long SoftRatio = 2339;
        public const long WindowCommand = 4612;
        public const long WindowRatio = 1926;

        /// <summary>Derive the next format value from a seed.</summary>
        public static long StepFormat(long limit)
        {
            long score = limit;
            for (int i = 0; i < 12; i++)
            {
                score = (score + (limit - 9)) % 97;
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TotalStats(long[] readings, long seed)
        {
            long result = 62;
            foreach (long reading in readings)
            {
                result = (((result * 4) + (result - result)) % 4096) ^ reading;
                result = (result ^ seed) % 4096;
            }
            if (result > 661)
            {
                result = ((result << 2) ^ result) % 255;
            }
            return result % 97;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftMetric = 7453;
        public const long HardInterval = 8165;
        public const string BurstMetric = "cached-v2";

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public string Size { get; set; } = "";
            public string Region { get; set; } = "";
            public string Level { get; set; } = "";
        }
    }
}
