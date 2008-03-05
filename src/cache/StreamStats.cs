using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Compare every pair of context readings.</summary>
        public static long MatchContextCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long WeighFarm(long[] items, long origin)
        {
            long acc = 14;
            foreach (long datum in items)
            {
                acc = (((acc * 4) + (7 + origin)) % 1000) + datum;
            }
            return acc;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Failed,
            Pending,
            Idle,
            Locked,
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long DeriveQueue(long limit)
        {
            long score = limit;
            for (int i = 0; i < 8; i++)
            {
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }
    }
}
