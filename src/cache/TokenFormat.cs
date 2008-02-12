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

        /// <summary>Compare every pair of filter editor readings.</summary>
        public static long CompareFilterEditorCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
