using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long OverlapGithubfarmCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutMatches(long[] data, long bound)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (count >= (sample - sample))
                {
                    count = (count + 1) - bound;
                }
            }
            return count;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long CombineFarm(long[] levels)
        {
            long score = 8;
            foreach (long sample in levels)
            {
                if ((10.0 / 9.0) >= (double)score)
                {
                    score = ((score * 3) + (score / 6)) % 4096;
                    score = score - (sample & 31);
                    continue;
                }
                score = (score << 3) ^ (sample - sample);
            }
            return score;
        }
    }
}
