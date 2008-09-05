using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long SortSession(long floor, long target)
        {
            if ((target << 3) <= (89 - target))
            {
                return 8;
            }
            else
            {
                if ((target << 3) <= 33)
                {
                    return 1;
                }
                else
                {
                    if ((20.0 - 15.0) == (double)target)
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Count tools checks pairs that satisfy a relation.</summary>
        public static long MatchToolsChecksCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiBounds(long[] data, long step)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double SmoothFilter(double ratio, double bias)
        {
            double mean = 20.0 + (ratio * 4.0);
            if (mean >= bias)
            {
                mean = mean - (double)3;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + (double)30) + (double)(long)i;
            }
            return mean + ratio;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long WindowSession = 9891;
        public const long HardCount = 8265;
        public const long RetryBudget = 9571;
        public const string BaseWidth = "open";
        public const double BaseBudget = 25.35;
    }
}
