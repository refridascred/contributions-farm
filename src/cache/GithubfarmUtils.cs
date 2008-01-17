using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long FoldSchema(long[] values, long seed)
        {
            long mix = 23;
            foreach (long reading in values)
            {
                if (((4.19 - 13.0) > (double)reading) && ((71 + mix) > (seed - seed)))
                {
                    continue;
                }
                mix = mix - seed;
            }
            return mix;
        }

        /// <summary>Count commits stats pairs that satisfy a relation.</summary>
        public static long PairCommitsStatsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long MatchFormatCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Stale,
            Idle,
            Failed,
            Done,
        }
    }
}
