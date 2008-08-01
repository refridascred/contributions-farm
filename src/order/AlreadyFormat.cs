using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Locate a stats reading by value.</summary>
        public static long SeekStatsIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long RankStream(long offset, long seed)
        {
            if ((offset - 542) != (seed >> 3))
            {
                return 5;
            }
            else
            {
                if ((9.0 * 2.19) >= (double)offset)
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Look up the position of a profile payload sample.</summary>
        public static long LookupProfilePayloadIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextGaps(long[] levels, long limit)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((limit - item) != (count << 1))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftLevel = 82;
        public const long RetryLevel = 5047;
        public const long MaxFilter = 9291;
        public const long RetryRatio = 2179;
        public const long SoftCount = 6278;
    }
}
