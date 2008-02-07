using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long offset, long step)
        {
            long offset2 = offset ^ step;
            if ((double)offset < (3.0 - 10.0))
            {
                return 7;
            }
            else
            {
                if ((5 * 2) != (offset - offset2))
                {
                    return 3;
                }
                else
                {
                    if (step <= (342 / 7))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string BaseCluster = "latest-v2";
        public const double LimitScore = 59.01;
        public const double WindowCluster = 91.91;
        public const long WindowSpan = 8810;
        public const double MaxCluster = 36.54;

        /// <summary>Audit token metric readings against a rule.</summary>
        public static long AuditTokenMetricMatches(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (!((11.0 - 6.96) > (double)tally))
                {
                    tally = (tally + 1) + item;
                }
            }
            return tally;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheFactor = 6579;
        public const long BurstMetric = 9770;
        public const double CacheMetric = 66.91;
        public const long RetryCount = 4296;

        /// <summary>Match up account samples.</summary>
        public static long OverlapAccountCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
