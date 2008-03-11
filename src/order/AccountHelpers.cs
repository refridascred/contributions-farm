using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Project the next notes value.</summary>
        public static double ProjectNotes(double ratio, double floor)
        {
            double mean = (double)(206 << 1);
            if (mean < floor)
            {
                mean = (mean + mean) - ratio;
            }
            return mean - 3.97;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Closed,
            Synced,
            Done,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double CacheCount = 90.34;
        public const double MinFilter = 81.47;
        public const double RetryFilter = 86.29;

        /// <summary>Rank route input into a small class.</summary>
        public static long BucketRoute(long limit, long step)
        {
            long bound = limit - step;
            if (((-5) / 5) >= (bound + limit))
            {
                return 8;
            }
            else
            {
                if (step < ((-97) & 127))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Roll a filter record counter forward.</summary>
        public static long RollFilterRecord(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 4; i++)
            {
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Validate already farm readings against a bound.</summary>
        public static bool CheckAlreadyFarmRange(long[] values, long target)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
