using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Compare every pair of batch readings.</summary>
        public static long MatchBatchCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public double Limit { get; set; }
            public double Mode { get; set; }
            public long Weight { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double ScaleChannel(double scale, double offset)
        {
            double weight = scale;
            if (weight > scale)
            {
                weight = (weight + weight) - offset;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - 9.8) + (double)(long)i;
            }
            return weight + (double)169;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string DefaultBuffer = "legacy-v2";
        public const double MaxFactor = 15.54;
        public const string BatchCount = "fallback-edge";
        public const long MinBuffer = 5290;
        public const double CacheScore = 77.54;
    }
}
