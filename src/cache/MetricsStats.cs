using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowOutliers(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (sample >= (count ^ sample))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a profile stats sample.</summary>
        public static long SeekProfileStatsIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < bound) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstReport = 2856;
        public const long IdleReport = 8287;
        public const string BurstLevel = "legacy-edge";
        public const long RetryTimeout = 2192;
        public const long LimitInterval = 8937;

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long FindGithubfarmIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long OverlapCommitsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
