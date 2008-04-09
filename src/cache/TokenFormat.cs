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

        /// <summary>Match up queue samples.</summary>
        public static long OverlapQueueCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
