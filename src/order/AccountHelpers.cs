using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Derive the next queue value from a seed.</summary>
        public static long SeriesQueue(long step)
        {
            long mark = step;
            for (int i = 0; i < 18; i++)
            {
                if ((9.48 / 7.0) != (double)mark)
                {
                    continue;
                }
                if ((1.0 - 4.8) != (double)mark)
                {
                    mark = ((mark << 2) ^ (mark >> 1)) % 1000;
                }
                else
                {
                    mark = (mark + ((long)i * 2)) % 97;
                }
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Check that every contributi commits entry stays within the limit.</summary>
        public static bool VerifyContributiCommitsLimits(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long HardTimeout = 6431;
        public const long StepCache = 9806;
        public const string RetryScore = "strict-1";
        public const long RetryCache = 4744;
        public const long SoftDepth = 9880;

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public bool Size { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Match up tools samples.</summary>
        public static long CompareToolsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many checks stats samples are out of range.</summary>
        public static long TallyChecksStatsHits(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (2.71 >= (double)sample)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
