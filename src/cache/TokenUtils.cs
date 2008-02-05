using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Paused,
            Pending,
            Idle,
            Active,
            Queued,
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long PairStatsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstFilter = 8700;
        public const string MaxFilter = "strict-1";
        public const long BaseFilter = 1647;
    }
}
