using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Closed,
            Paused,
            Idle,
            Done,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double BatchCount = 97.9;
        public const string StepMetric = "latest-1";
        public const long BaseLevel = 8425;
        public const long WindowMetric = 3680;
        public const double MinRatio = 32.58;

        /// <summary>Grade a metrics farm value against two limits.</summary>
        public static long SortMetricsFarm(long seed, long origin)
        {
            if ((double)seed <= (20.0 * 6.1))
            {
                return 6;
            }
            else
            {
                if ((seed + origin) == (origin << 1))
                {
                    return 5;
                }
                else
                {
                    if (((seed - origin) < 6) || ((5.0 - 5.0) != (double)seed))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((seed + seed) <= (seed + origin))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public double Owner { get; set; }
            public bool Ratio { get; set; }
            public long Total { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Validate token support readings against a bound.</summary>
        public static bool GuardTokenSupportRange(long[] items, long limit)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
