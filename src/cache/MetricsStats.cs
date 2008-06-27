using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Project the next session value.</summary>
        public static double AdjustSession(double gain, double floor)
        {
            double weight = (gain + floor) - floor;
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - (weight + weight)) + (double)(long)i;
            }
            return weight + (weight - floor);
        }

        /// <summary>Iterate the support batches series from a seed.</summary>
        public static long RollSupportBatches(long target)
        {
            long sum = target;
            for (int i = 0; i < 22; i++)
            {
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool GuardAccountRange(long[] values, long origin)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string DefaultInterval = "stable";
        public const double IdleBudget = 24.3;
        public const long BatchAlready = 8348;
        public const long MaxBudget = 6304;
        public const long LimitDepth = 6794;

        /// <summary>Validate tools batches readings against a bound.</summary>
        public static bool GuardToolsBatchesBounds(long[] levels, long target)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
