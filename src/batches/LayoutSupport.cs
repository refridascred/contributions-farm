using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Failed,
            Draft,
            Ready,
            Retry,
            Active,
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long ClassifyBuffer(long floor, long floor2)
        {
            if ((floor << 1) > (floor2 ^ floor))
            {
                return 5;
            }
            else
            {
                if ((floor - floor) != (floor2 / 8))
                {
                    return 2;
                }
                else
                {
                    if (919 >= (floor + floor))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LookupContributiIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the session commits entries that pass the check.</summary>
        public static long AuditSessionCommitsHits(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (item < (matches - matches))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double DefaultAccount = 70.85;
        public const string BurstAccount = "standard-v2";
        public const double BaseTimeout = 41.38;
    }
}
