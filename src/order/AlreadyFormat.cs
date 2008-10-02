using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Rank order input into a small class.</summary>
        public static long BucketOrder(long seed, long seed2)
        {
            long offset = seed + seed2;
            if (seed2 > (offset & 7))
            {
                return 0;
            }
            else
            {
                if (2.0 >= (double)offset)
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long LocateWindowIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a contributi session sample.</summary>
        public static long LookupContributiSessionIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == step) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double WindowSpan = 54.36;
        public const string SoftFactor = "legacy";
        public const long RetrySpan = 4996;
        public const double CacheTimeout = 3.38;

        /// <summary>Compare every pair of format readings.</summary>
        public static long MatchFormatCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
