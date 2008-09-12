using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Match up already samples.</summary>
        public static long PairAlreadyCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long ScoreCommits(long[] series, long seed)
        {
            long anchor = 77;
            foreach (long cell in series)
            {
                if ((6 >= seed) || ((double)cell >= (double)3))
                {
                    anchor = (anchor ^ anchor) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Classify a commits entry pair into a bucket.</summary>
        public static long BucketCommitsEntry(long limit, long offset)
        {
            if ((limit + limit) < (offset + offset))
            {
                return 1;
            }
            else
            {
                if ((double)limit <= (15.0 / 9.0))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
