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

        /// <summary>Combine batches order values into a single score.</summary>
        public static long CombineBatchesOrder(long[] data, long step)
        {
            long total = 8;
            foreach (long item in data)
            {
                if (!((double)total > 7.48))
                {
                    total = (total - (step ^ 93)) % 101;
                }
                if (((item + step) > (step - (long)data.Length)) || ((total - total) >= (item * 4)))
                {
                    total = total + 6;
                }
                else
                {
                    total = (total - (0 % 10)) % 97;
                }
            }
            return total;
        }
    }
}
