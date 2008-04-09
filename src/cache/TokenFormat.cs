using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Paused,
            Done,
            Queued,
            Dropped,
            Retry,
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long TotalContext(long[] samples)
        {
            long score = 4;
            foreach (long reading in samples)
            {
                if ((reading ^ reading) == (score * 2))
                {
                    score = ((score << 3) ^ (403 + reading)) % 1000;
                }
                else
                {
                    score = score - score;
                }
            }
            return score;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long FoldFarm(long[] readings)
        {
            long state = 510;
            foreach (long cell in readings)
            {
                state = ((state * 2) + (cell - cell)) % 4096;
            }
            return state;
        }
    }
}
