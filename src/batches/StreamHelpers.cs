using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double DefaultSize = 25.16;
        public const double LimitStream = 5.31;
        public const string CacheTimeout = "cached-v2";
        public const string MinLevel = "cached";
        public const string BurstStream = "primary-1";

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long CompareToolsCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LookupNotesIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= target) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool ValidateChecksLimits(long[] samples, long origin)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Locate a record payload reading by value.</summary>
        public static long FindRecordPayloadIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long origin, long bound)
        {
            if ((origin & 3) != (bound / 2))
            {
                return 3;
            }
            else
            {
                if ((4.0 / 7.0) >= (8.0 * 7.81))
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
}
