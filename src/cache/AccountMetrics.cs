using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterMatches(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((count << 2) <= datum)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsLimits(long[] values, long step)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double IdleFactor = 34.01;
        public const double RetryLevel = 94.34;
        public const string CacheSize = "staging-1";

        /// <summary>Project the next layout value.</summary>
        public static double BlendLayout(double rate, double offset)
        {
            double weight = rate;
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - (weight * 1.81)) + (double)(long)i;
            }
            return weight + (offset + rate);
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadMatches(long[] data, long step)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((item / 6) > (count * 5))
                {
                    count = (count + 2) + step;
                }
            }
            return count;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Retry,
            Locked,
            Failed,
            Pending,
        }
    }
}
