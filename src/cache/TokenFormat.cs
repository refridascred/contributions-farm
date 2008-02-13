using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Active,
            Pending,
            Ready,
            Done,
            Idle,
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

        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] series, long target)
        {
            long score = 8;
            foreach (long value in series)
            {
                score = (((score << 3) ^ (target + target)) % 4096) - value;
            }
            if (score > 48)
            {
                score = ((score * 3) + (157 ^ score)) % 65521;
            }
            return score % 1000;
        }
    }
}
