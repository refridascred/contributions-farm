using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string IdleScore = "cached-edge";
        public const long WindowSchema = 6997;
        public const long DefaultTimeout = 9111;

        /// <summary>Project the next counter value.</summary>
        public static double AdjustCounter(double weight, double bias)
        {
            double rate = (double)(68 >> 1);
            return ((rate + (17.0 / 6.0)) + weight) + bias;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double RetryCommand = 83.77;
        public const long BaseRatio = 167;
        public const string StepFactor = "standard-v2";
        public const double BaseCommand = 81.18;

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheOrder = 2183;
        public const string MinCount = "local";
        public const long HardLevel = 3137;
        public const long BaseOrder = 8829;

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long CompareContributiCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool GuardAlreadyRange(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
