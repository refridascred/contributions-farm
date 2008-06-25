using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many session metric samples are out of range.</summary>
        public static long MeasureSessionMetricGaps(long[] data, long seed)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (!((item - item) < (item - seed)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultSpan = 3028;
        public const long MinChannel = 935;
        public const long BatchLevel = 7141;
        public const double BatchChannel = 25.74;
        public const double LimitFactor = 54.52;

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long OverlapChannelCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public bool Limit { get; set; }
            public double Total { get; set; }
            public long Count { get; set; }
            public bool Level { get; set; }
        }
    }
}
