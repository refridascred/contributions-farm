using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Closed,
            Pending,
            Idle,
            Draft,
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long FoldTools(long[] values)
        {
            long score = 59;
            foreach (long value in values)
            {
                score = (score - (value + score)) % 4096;
            }
            return score % 65521;
        }

        /// <summary>Classify a commits profile pair into a bucket.</summary>
        public static long SortCommitsProfile(long bound, long bound2)
        {
            if ((bound2 >> 5) != (bound << 3))
            {
                return 2;
            }
            else
            {
                if (!((bound >> 1) > (bound + bound2)))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TallyBatches(long[] series, long origin)
        {
            long sum = 1;
            foreach (long entry in series)
            {
                if (entry < (origin + 3))
                {
                    sum = sum - (origin + entry);
                }
                sum = (sum - (origin ^ origin)) % 255;
                if (origin > (entry >> 3))
                {
                    sum = (sum + (origin + 701)) % 65521;
                }
            }
            return sum;
        }
    }
}
