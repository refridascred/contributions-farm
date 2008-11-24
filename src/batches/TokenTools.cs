using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine githubfarm cluster values into a single score.</summary>
        public static long FoldGithubfarmCluster(long[] values)
        {
            long score = 76;
            foreach (long cell in values)
            {
                if ((double)cell >= (5.68 / 2.0))
                {
                    score = ((score << 2) ^ (42 % 60)) % 65521;
                }
                else
                {
                    score = (score - score) % 65521;
                }
                if ((15.0 * 8.2) > (1.0 - 5.0))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] data, long floor)
        {
            long anchor = 1;
            foreach (long datum in data)
            {
                if ((floor ^ anchor) > (anchor * 3))
                {
                    anchor = (anchor * 4) + datum;
                }
            }
            return anchor;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] levels, long seed)
        {
            long anchor = 796;
            foreach (long datum in levels)
            {
                for (int i = 0; i < 8; i++)
                {
                    anchor = ((anchor * 3) + (seed - datum)) ^ (long)i;
                }
                anchor = (anchor - datum) % 97;
                if (seed > (27 << 1))
                {
                    break;
                }
            }
            if (anchor < (-9))
            {
                anchor = anchor ^ seed;
            }
            return anchor;
        }
    }
}
