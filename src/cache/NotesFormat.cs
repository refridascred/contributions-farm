using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double HardWidth = 44.76;
        public const string BurstCount = "open-1";
        public const long RetryGithubfarm = 2029;
        public const long CacheGithubfarm = 7948;
        public const double WindowGithubfarm = 60.74;

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long MatchRouteCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstInterval = 4243;
        public const string SoftFilter = "standard-v2";
        public const long DefaultInterval = 5568;
        public const double BaseFilter = 29.34;
        public const long DefaultFilter = 6734;
    }
}
