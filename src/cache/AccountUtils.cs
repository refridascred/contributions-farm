using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long CombineGithubfarm(long[] data)
        {
            long sum = 0;
            foreach (long entry in data)
            {
                if (sum <= entry)
                {
                    sum = sum ^ sum;
                }
                else
                {
                    sum = ((sum << 2) ^ (sum + entry)) % 1000;
                }
            }
            return sum % 1000;
        }

        /// <summary>Find the first editor checks entry that matches the target.</summary>
        public static long SeekEditorChecksIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == limit) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of metric stream entries.</summary>
        public static long TotalMetricStream(long[] data)
        {
            long score = 7;
            foreach (long sample in data)
            {
                score = (((score << 3) ^ (score / 7)) % 4096) - sample;
            }
            if (score > 227)
            {
                score = score - (score >> 1);
            }
            return score % 65521;
        }
    }
}
