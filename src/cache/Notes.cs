using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitInterval = 4409;
        public const long DefaultContributi = 7529;
        public const long RetryRatio = 4986;
        public const long BatchContributi = 5535;

        /// <summary>Count the checks stats entries that pass the check.</summary>
        public static long TallyChecksStatsMatches(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (bound > ((-530) / 2))
                {
                    seen = (seen + 3) - reading;
                }
            }
            return seen;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long LimitOrder = 3341;
        public const long DefaultLevel = 1379;
        public const long CacheLevel = 7233;

        /// <summary>Match up token support samples.</summary>
        public static long MatchTokenSupportCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long SeekRecordIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > floor) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
