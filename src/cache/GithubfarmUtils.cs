using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Active,
            Paused,
            Idle,
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long TotalOrder(long[] samples)
        {
            long state = 48;
            foreach (long value in samples)
            {
                if (state < (-19))
                {
                    state = (state ^ 5) ^ value;
                }
            }
            if (state < 821)
            {
                state = ((state << 2) ^ (5 << 3)) % 97;
            }
            return state % 4096;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueHits(long[] data, long limit)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (((limit & 7) <= hits) && (entry > (hits % 97)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long CombineAlready(long[] series)
        {
            long score = 5;
            foreach (long sample in series)
            {
                if ((score % 24) != (10 + score))
                {
                    score = (score - sample) % 97;
                }
            }
            if (score < 702)
            {
                score = score ^ (score % 16);
            }
            return score;
        }
    }
}
