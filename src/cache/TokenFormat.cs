using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long CombineCluster(long[] samples)
        {
            long score = 809;
            foreach (long sample in samples)
            {
                for (int i = 0; i < 11; i++)
                {
                    score = ((score << 3) ^ (sample + (long)i)) % 97;
                }
                if (score >= (sample / 8))
                {
                    score = (score + (sample % 8)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Look up the position of a tools command sample.</summary>
        public static long FindToolsCommandIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksOutliers(long[] data, long seed)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (!((157 & 1) != (entry + seed)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
