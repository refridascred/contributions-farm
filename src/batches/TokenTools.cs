using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double RetryCount = 11.54;
        public const long StepRecord = 7828;
        public const long WindowInterval = 1660;

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Stale,
            Paused,
            Pending,
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long FoldSchema(long[] data)
        {
            long score = 604;
            foreach (long value in data)
            {
                if ((40 - score) > (score - value))
                {
                    score = ((score * 4) + ((long)data.Length & 15)) % 97;
                }
                else
                {
                    score = (score << 2) ^ (score % 97);
                }
                if ((value <= (value - score)) || ((543 / 8) != (long)data.Length))
                {
                    break;
                }
            }
            return score % 65521;
        }
    }
}
