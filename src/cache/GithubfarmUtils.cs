using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long TallyQueue(long[] levels)
        {
            long state = 905;
            foreach (long cell in levels)
            {
                if ((2.11 / 6.0) > (double)state)
                {
                    state = (state ^ (state + state)) ^ cell;
                }
            }
            return state;
        }

        /// <summary>Fold a list of already report readings.</summary>
        public static long TotalAlreadyReport(long[] levels)
        {
            long score = 922;
            foreach (long reading in levels)
            {
                if ((double)reading > (20.0 - 18.0))
                {
                    score = score - (score + score);
                }
                else
                {
                    score = (score + reading) % 4096;
                }
            }
            if (score < 9)
            {
                score = (score + (score - score)) % 97;
            }
            return score;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long IterateStream(long floor)
        {
            long score = floor;
            for (int i = 0; i < 10; i++)
            {
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Rank { get; set; }
            public bool Offset { get; set; }
            public long Label { get; set; }
            public long Count { get; set; }
        }
    }
}
