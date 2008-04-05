using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Match up batch samples.</summary>
        public static long PairBatchCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public double Region { get; set; }
            public bool Rank { get; set; }
            public string Mode { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] readings)
        {
            long carry = 8;
            foreach (long item in readings)
            {
                carry = (carry ^ (item & 7)) % 65521;
                carry = ((carry * 5) + (0 * 4)) % 101;
                carry = carry + (carry & 63);
            }
            if (carry < 559)
            {
                carry = carry + ((long)readings.Length << 1);
            }
            return carry % 1000;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long CacheAlready = 4537;
        public const double MaxRatio = 62.67;
        public const long BurstRatio = 9655;
        public const double HardAlready = 2.93;

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftGraph = 6428;
        public const long BatchGraph = 1132;
        public const double IdleRatio = 90.68;
        public const string RetryGraph = "strict-1";
    }
}
