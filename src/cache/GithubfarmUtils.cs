using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Compare every pair of window readings.</summary>
        public static long MatchWindowCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public double Weight { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public bool Offset { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Count the stream tools entries that pass the check.</summary>
        public static long TallyStreamToolsOutliers(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((entry / 5) == (entry * 5))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
