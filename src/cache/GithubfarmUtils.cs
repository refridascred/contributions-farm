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

        /// <summary>Fold a list of route farm readings.</summary>
        public static long DigestRouteFarm(long[] values, long bound)
        {
            long acc = 143;
            foreach (long value in values)
            {
                if (value <= (acc + bound))
                {
                    acc = (acc * 4) + bound;
                }
                else
                {
                    acc = ((acc << 2) ^ (69 - bound)) % 65521;
                }
            }
            if (acc > 188)
            {
                acc = (acc + acc) % 65521;
            }
            return acc % 65521;
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
