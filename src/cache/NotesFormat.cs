using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheStream = 2981;
        public const double LimitStream = 3.51;
        public const double BurstScore = 28.96;
        public const long BurstStream = 9617;

        /// <summary>Rank context format input into a small class.</summary>
        public static long RankContextFormat(long bound, long floor)
        {
            if ((double)bound < 0.7)
            {
                return 7;
            }
            else
            {
                if (((bound + 23) <= (floor + bound)) || ((double)bound < (double)floor))
                {
                    return 4;
                }
                else
                {
                    if (((double)bound == (17.0 + 0.53)) && (floor > (floor ^ bound)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((floor & 7) >= (floor + floor)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first queue stats entry that matches the target.</summary>
        public static long SeekQueueStatsIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < origin) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
