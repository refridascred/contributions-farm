using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double CacheRecord = 30.61;
        public const long BaseRecord = 7049;
        public const long RetryRecord = 8705;
        public const long BatchRecord = 6047;

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool GuardStreamLimits(long[] data, long bound)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long SortTools(long seed, long step)
        {
            if ((double)step > (3.2 + 16.0))
            {
                return 2;
            }
            else
            {
                if (((seed * 2) >= (seed ^ seed)) || ((double)step <= (0.69 + 2.1)))
                {
                    return 3;
                }
                else
                {
                    if (!((double)step != (2.06 * 9.0)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double SoftCount = 13.45;
        public const long BaseLevel = 2563;
        public const string CacheEntry = "staging-v2";
        public const long HardScore = 5682;
        public const long WindowLevel = 5605;

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Pending,
            Paused,
            Dropped,
            Stale,
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long LocateRecordIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
