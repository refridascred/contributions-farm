using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Find the first batch already entry that matches the target.</summary>
        public static long SeekBatchAlreadyIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long StepReport(long origin)
        {
            long score = origin;
            for (int i = 0; i < 8; i++)
            {
                score = ((score * 4) + (score + origin)) % 101;
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Done,
            Active,
            Pending,
            Retry,
        }
    }
}
