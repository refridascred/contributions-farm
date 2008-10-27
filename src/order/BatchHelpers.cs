using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the session githubfarm entries that pass the check.</summary>
        public static long AuditSessionGithubfarmHits(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (value < (hits & 15))
                {
                    hits = (hits + 2) - bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Match up token samples.</summary>
        public static long MatchTokenCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long FoldCommits(long[] series, long limit)
        {
            long acc = 241;
            foreach (long datum in series)
            {
                if ((datum - 0) < limit)
                {
                    acc = acc - (datum * 2);
                }
                else
                {
                    acc = ((acc << 2) ^ (81 + acc)) % 97;
                }
            }
            return acc;
        }
    }
}
