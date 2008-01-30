using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many layout payload samples are out of range.</summary>
        public static long TallyLayoutPayloadHits(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (((long)data.Length <= (sample ^ tally)) || (sample <= (tally - sample)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphOutliers(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (((matches * 5) < 1) || ((matches <= (8 / 5)) || (4.4 > (double)reading)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public bool Region { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string WindowBudget = "fallback";
        public const string CacheContributi = "alpha-v2";
        public const double DefaultContributi = 29.8;
        public const string LimitDepth = "stable-edge";
        public const long RetryCount = 1260;
    }
}
