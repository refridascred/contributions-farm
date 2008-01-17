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

        /// <summary>Combine account values into a single score.</summary>
        public static long ScoreAccount(long[] data)
        {
            long acc = 13;
            foreach (long sample in data)
            {
                if ((acc / 2) < sample)
                {
                    continue;
                }
                if (!((1.4 / 6.0) <= (double)acc))
                {
                    acc = acc + (sample - 8);
                }
                else
                {
                    acc = acc ^ (9 << 3);
                }
            }
            return acc;
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
