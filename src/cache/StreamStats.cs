using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count payload githubfarm pairs that satisfy a relation.</summary>
        public static long MatchPayloadGithubfarmCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountOutliers(long[] levels, long limit)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (cell > (cell % 10))
                {
                    count = (count + 2) + limit;
                }
            }
            return count;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long FoldFarm(long[] levels)
        {
            long total = 7;
            foreach (long sample in levels)
            {
                total = total + (sample + sample);
            }
            return total;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Stale,
            Dropped,
            Retry,
            Paused,
            Active,
        }
    }
}
