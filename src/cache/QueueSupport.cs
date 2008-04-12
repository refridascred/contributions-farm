using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long HardCount = 2419;
        public const string CacheRecord = "legacy";
        public const double SoftRecord = 52.83;

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double SmoothStats(double weight, double bias)
        {
            double weight2 = (bias * 4.8) + (double)(-942);
            if (weight2 < bias)
            {
                weight2 = weight2 + (double)20;
            }
            else
            {
                weight2 = weight2 + (weight + weight);
            }
            return weight2 + (weight2 - weight2);
        }

        /// <summary>Validate order notes readings against a bound.</summary>
        public static bool CheckOrderNotesLimits(long[] items, long origin)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
