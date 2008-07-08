using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long FoldPayload(long[] samples, long target)
        {
            long sum = 7;
            foreach (long entry in samples)
            {
                if (70 > sum)
                {
                    sum = ((sum * 3) + (entry & 255)) % 4096;
                }
                sum = (sum - (target % 10)) % 4096;
            }
            return sum % 4096;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutRange(long[] data, long floor)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Idle,
            Closed,
            Stale,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MinCounter = 2468;
        public const long CacheRatio = 8080;
        public const long BurstRatio = 2625;
        public const long StepDepth = 9528;
        public const long BaseCounter = 1348;
    }
}
