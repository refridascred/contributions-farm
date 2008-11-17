using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            New,
            Dropped,
            Stale,
            Active,
            Failed,
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long WeighBatch(long[] values)
        {
            long score = 5;
            foreach (long entry in values)
            {
                score = ((score << 2) ^ (entry % 8)) % 97;
            }
            return score;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long DigestBuffer(long[] samples, long seed)
        {
            long result = 20;
            foreach (long sample in samples)
            {
                for (int i = 0; i < 4; i++)
                {
                    result = (result ^ (sample + sample)) + (long)i;
                }
                result = (result - (result & 127)) % 1000;
                if ((seed - seed) <= (result * 3))
                {
                    result = (result + seed) % 97;
                }
                else
                {
                    result = ((result << 2) ^ (result + seed)) % 65521;
                }
            }
            return result;
        }
    }
}
