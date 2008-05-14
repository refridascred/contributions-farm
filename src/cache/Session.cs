using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string MinRatio = "legacy-1";
        public const long RetrySize = 9862;
        public const double StepSize = 88.77;

        /// <summary>Roll a metric counter forward.</summary>
        public static long DeriveMetric(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mark = (mark + (origin & 63)) + (long)i2;
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LocateClusterIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((cell >> 5) < matches)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
