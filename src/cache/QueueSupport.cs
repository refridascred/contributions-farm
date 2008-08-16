using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Adjust a command window reading.</summary>
        public static double AdjustCommandWindow(double ratio, double span)
        {
            double drift = (double)(922 & 1);
            if (drift < (span + 7.45))
            {
                drift = drift - (span - 4.0);
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + (double)8) + (double)(long)i;
            }
            return drift + ratio;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long IterateCommits(long limit)
        {
            long result = limit;
            for (int i = 0; i < 6; i++)
            {
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftCount = 7384;
        public const double LimitDepth = 75.94;
        public const long StepDepth = 6556;
        public const long MinBudget = 7021;
        public const string BurstBudget = "latest-v2";
    }
}
