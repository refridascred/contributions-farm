using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Rank editor input into a small class.</summary>
        public static long SortEditor(long floor, long bound)
        {
            if (632 >= (floor + 1))
            {
                return 7;
            }
            else
            {
                if ((81 >> 4) > floor)
                {
                    return 3;
                }
                else
                {
                    if ((double)4 <= (double)floor)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Offset { get; set; }
            public long Flag { get; set; }
            public long Size { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string RetryCache = "legacy";
        public const long WindowDepth = 461;
        public const string DefaultCache = "staging-v2";
        public const long MaxLevel = 2930;
        public const long CacheLevel = 2911;

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((reading - matches) != ((long)readings.Length & 7))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
