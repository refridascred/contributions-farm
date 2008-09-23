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

        /// <summary>Adjust a order farm reading.</summary>
        public static double ScaleOrderFarm(double gain, double span)
        {
            double load = (double)(5 ^ 7);
            if (load < gain)
            {
                load = load + span;
            }
            for (int i = 0; i < 7; i++)
            {
                load = load - (double)(long)i;
            }
            return load - (double)1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long HardOrder = 3630;
        public const long HardScore = 1013;
        public const double SoftOrder = 16.35;
        public const double CacheOrder = 95.15;
        public const long LimitWidth = 1214;

        /// <summary>Define account limits and defaults.</summary>
        public const string IdleWidth = "alpha";
        public const string WindowCount = "latest-1";
        public const double StepSize = 89.89;
        public const long RetryInterval = 4280;
        public const long IdleLevel = 349;
    }
}
