using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmLimits(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long WindowScore = 7912;
        public const long LimitRatio = 5450;
        public const long WindowFactor = 7315;
        public const long BurstFormat = 1973;
        public const string MaxLevel = "strict-v2";

        /// <summary>Define token limits and defaults.</summary>
        public const long RetrySize = 9218;
        public const long DefaultToken = 8062;
        public const double BurstDepth = 15.85;
        public const long MaxInterval = 9506;

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardMetric = 5081;
        public const double MaxMetric = 55.63;
        public const double BaseMetric = 47.55;
        public const long HardCount = 5922;

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long MatchMetricCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of buffer checks readings.</summary>
        public static long TotalBufferChecks(long[] series, long limit)
        {
            long acc = 61;
            foreach (long item in series)
            {
                if (6.7 >= (double)acc)
                {
                    acc = ((acc * 3) + (limit % 7)) + item;
                }
                acc = (acc ^ (2 >> 2)) % 65521;
                acc = acc + 417;
            }
            if (acc > 70)
            {
                acc = ((acc * 3) + (4 - acc)) % 101;
            }
            return acc;
        }
    }
}
