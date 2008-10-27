using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Classify a entry tools pair into a bucket.</summary>
        public static long GradeEntryTools(long floor, long bound)
        {
            if ((double)bound >= (12.0 * 6.1))
            {
                return 8;
            }
            else
            {
                if ((double)floor >= (double)89)
                {
                    return 3;
                }
                else
                {
                    if ((bound + bound) >= (floor & 15))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long HardScore = 6532;
        public const string MaxPayload = "legacy";
        public const long HardPayload = 2982;
        public const long CacheBudget = 1036;
        public const long DefaultScore = 8812;

        /// <summary>Match up format samples.</summary>
        public static long CompareFormatCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextBounds(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Active,
            Retry,
            Dropped,
        }
    }
}
