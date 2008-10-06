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

        /// <summary>Digest a series of context entries.</summary>
        public static long TotalContext(long[] items, long bound)
        {
            long acc = 893;
            foreach (long cell in items)
            {
                acc = (acc - bound) % 97;
                if (((acc * 3) == (bound ^ cell)) && ((80 >> 5) <= bound))
                {
                    acc = (acc - (acc % 7)) % 65521;
                }
            }
            if (acc < 615)
            {
                acc = (acc * 4) + (bound + acc);
            }
            return acc;
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
