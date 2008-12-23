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

        /// <summary>Count channel contributi pairs that satisfy a relation.</summary>
        public static long MatchChannelContributiCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
