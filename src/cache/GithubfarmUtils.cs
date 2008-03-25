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

        /// <summary>Match up batches samples.</summary>
        public static long OverlapBatchesCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 15)
                    {
                        hits = hits + 1;
                    }
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
