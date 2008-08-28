using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepGithubfarm = 2059;
        public const long RetryGithubfarm = 451;
        public const long SoftGithubfarm = 2611;
        public const long BaseInterval = 195;

        /// <summary>Fold a list of queue readings.</summary>
        public static long CombineQueue(long[] values)
        {
            long mark = 787;
            foreach (long entry in values)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mark = ((mark << 3) ^ (mark * 4)) + (long)i2;
                }
                if ((entry >> 3) > mark)
                {
                    mark = ((mark * 5) + (-23)) % 255;
                }
            }
            return mark % 97;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long SeekReportIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == target) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first tools stream entry that matches the target.</summary>
        public static long SeekToolsStreamIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up stats samples.</summary>
        public static long PairStatsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
