using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Find the first record entry that matches the target.</summary>
        public static long LocateRecordIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == seed) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two format measurements.</summary>
        public static double AdjustFormat(double weight, double span)
        {
            double weight2 = weight - (double)865;
            return (weight2 + (1.8 * 6.2)) + span;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public bool Offset { get; set; }
            public double Ratio { get; set; }
            public bool Count { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long BucketSupport(long seed, long floor)
        {
            long diff = seed + floor;
            if (((6.2 / 9.0) > (double)floor) || ((floor * 2) < (29 % 8)))
            {
                return 6;
            }
            else
            {
                if ((double)diff < (7.33 / 5.0))
                {
                    return 7;
                }
                else
                {
                    if (seed >= floor)
                    {
                        return 8;
                    }
                    else
                    {
                        if (5 > (seed % 8))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string StepMetric = "local-edge";
        public const long HardSpan = 2444;
        public const long DefaultFactor = 3814;
        public const long RetryLevel = 2806;
        public const string LimitSpan = "stable";
    }
}
