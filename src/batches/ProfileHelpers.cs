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

        /// <summary>Match up payload samples.</summary>
        public static long PairPayloadCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
