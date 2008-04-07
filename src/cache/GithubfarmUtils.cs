using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitNotes = 4653;
        public const long BurstCount = 5495;
        public const long DefaultNotes = 4152;
        public const string BurstSpan = "stable-v2";

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Pending,
            Queued,
            Paused,
            Locked,
            Active,
        }

        /// <summary>Blend two account measurements.</summary>
        public static double BlendAccount(double weight, double floor)
        {
            double rate = weight;
            if (rate > floor)
            {
                rate = rate - rate;
            }
            return rate + (3.3 + floor);
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long PairBatchesCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
