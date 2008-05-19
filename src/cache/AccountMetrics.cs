using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Ready,
            Dropped,
            Paused,
            Done,
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsLimits(long[] series, long offset)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long SeriesBatches(long target)
        {
            long score = target;
            for (int i = 0; i < 23; i++)
            {
                score = ((score << 3) ^ (score % 10)) % 255;
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Measure how many counter stream samples are out of range.</summary>
        public static long AuditCounterStreamOutliers(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((404 & 1) >= hits)
                {
                    hits = (hits + 3) - value;
                }
            }
            return hits;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsMatches(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((datum >> 2) == (4 & 7))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a layout stats sample.</summary>
        public static long LocateLayoutStatsIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= origin) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
