using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long SortNotes(long floor, long limit)
        {
            long slot = floor - limit;
            if ((double)slot >= (9.41 - 9.22))
            {
                return 4;
            }
            else
            {
                if (((-98) - floor) != (3 - slot))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
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
