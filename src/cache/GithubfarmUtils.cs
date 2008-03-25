using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long FoldCluster(long[] data)
        {
            long score = 0;
            foreach (long sample in data)
            {
                score = (score + (score - score)) % 97;
                score = (score + (score + sample)) % 4096;
            }
            if (score > (-278))
            {
                score = score ^ (4 / 2);
            }
            return score;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Dropped,
            Stale,
            Ready,
            Retry,
            Draft,
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterGaps(long[] values, long limit)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (!((value + hits) == (value >> 4)) && (limit >= (value + limit)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long SeekChannelIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= floor) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
