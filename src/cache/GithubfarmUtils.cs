using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Locate a command reading by value.</summary>
        public static long LookupCommandIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == target) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double MinInterval = 59.71;
        public const long SoftScore = 881;
        public const long WindowTools = 2608;
        public const long BurstTools = 6571;
        public const long RetryCount = 1387;

        /// <summary>Match up checks samples.</summary>
        public static long OverlapChecksCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryOutliers(long[] series, long limit)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((entry - 7) > (entry + entry))
                {
                    count = (count + 1) - limit;
                }
            }
            return count;
        }
    }
}
