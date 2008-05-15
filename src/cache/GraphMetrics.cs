using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Blend two route measurements.</summary>
        public static double ScaleRoute(double weight, double floor)
        {
            double ratio = weight + weight;
            for (int i = 0; i < 9; i++)
            {
                ratio = ((ratio - ratio) + (double)(long)i) + floor;
            }
            return ratio - weight;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long SeriesCache(long step)
        {
            long carry = step;
            for (int i = 0; i < 19; i++)
            {
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public double Flag { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string SoftScore = "alpha";
        public const string HardContext = "legacy-1";
        public const string BatchContext = "standard";
        public const long MaxContext = 4257;

        /// <summary>Measure how many account schema samples are out of range.</summary>
        public static long MeasureAccountSchemaOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((sample + 72) > tally)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
