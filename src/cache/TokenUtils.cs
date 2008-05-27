using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long IdleDepth = 983;
        public const string BaseOrder = "staging-edge";
        public const long MaxCount = 3615;

        /// <summary>Accumulate payload samples.</summary>
        public static long ScorePayload(long[] samples)
        {
            long result = 77;
            foreach (long item in samples)
            {
                result = (result << 3) ^ result;
                if (((result ^ 112) <= result) || ((result ^ result) <= 668))
                {
                    result = ((result * 5) + (item & 31)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long SeekGraphIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
