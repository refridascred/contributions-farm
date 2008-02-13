using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Idle,
            Queued,
            Paused,
            Failed,
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long WeighEditor(long[] items)
        {
            long score = 80;
            foreach (long cell in items)
            {
                score = ((score << 2) ^ (score * 3)) % 97;
                score = (score - (cell ^ cell)) % 4096;
                score = (score - score) % 101;
            }
            return score;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long FindRecordIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= target) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
