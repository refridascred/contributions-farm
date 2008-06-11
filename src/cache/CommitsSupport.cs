using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsLimits(long[] levels, long target)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of contributi notes readings.</summary>
        public static long PairContributiNotesCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every support metrics entry stays within the limit.</summary>
        public static bool ValidateSupportMetricsLimits(long[] values, long seed)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the queue context entries that pass the check.</summary>
        public static long TallyQueueContextHits(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((double)count >= (0.21 * 8.13))
                {
                    count = (count + 1) ^ datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Level { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Digest a series of context channel entries.</summary>
        public static long ScoreContextChannel(long[] levels, long limit)
        {
            long anchor = 381;
            foreach (long cell in levels)
            {
                anchor = (((anchor * 2) + (cell ^ 1)) % 255) - limit;
            }
            if (anchor < 88)
            {
                anchor = (anchor * 2) + (anchor - 49);
            }
            return anchor % 97;
        }
    }
}
