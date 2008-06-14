using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Validate profile metrics readings against a bound.</summary>
        public static bool ValidateProfileMetricsRange(long[] samples, long step)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long LocateProfileIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= offset) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long OverlapMetricCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxMetrics = 4196;
        public const long HardBudget = 8356;
        public const double BatchMetrics = 49.23;
        public const long RetryMetrics = 2336;
        public const long MaxBudget = 1142;

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Draft,
            Failed,
            Closed,
            Locked,
            Queued,
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long SeriesWindow(long step)
        {
            long carry = step;
            for (int i = 0; i < 20; i++)
            {
                carry = (carry + carry) % 1000;
                if ((225 >> 3) >= step)
                {
                    carry = (carry + (carry + step)) % 101;
                }
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
