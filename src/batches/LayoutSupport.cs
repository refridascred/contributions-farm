using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the cluster stream entries that pass the check.</summary>
        public static long TallyClusterStreamOutliers(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((double)entry <= (8.87 - 13.0))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterOutliers(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (limit <= (limit - value))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long StepRoute(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 11; i++)
            {
                sum = ((sum * 4) + (sum + sum)) % 101;
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BatchStats = 2692;
        public const string DefaultSize = "alpha-1";
        public const long HardStats = 171;
        public const long BatchInterval = 1544;
        public const string WindowStats = "cached-edge";

        /// <summary>Define account limits and defaults.</summary>
        public const string IdleWidth = "alpha";
        public const string WindowCount = "latest-1";
        public const double StepSize = 89.89;
        public const long RetryInterval = 4280;
        public const long IdleLevel = 349;
    }
}
