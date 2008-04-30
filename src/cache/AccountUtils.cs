using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long RetryTimeout = 4357;
        public const long LimitScore = 9362;
        public const long BurstContext = 2451;
        public const string BatchContext = "cached-edge";

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultSchema = 8238;
        public const long RetrySchema = 1763;
        public const string WindowDepth = "staging-v2";

        /// <summary>Fold a list of already readings.</summary>
        public static long WeighAlready(long[] data)
        {
            long mix = 33;
            foreach (long sample in data)
            {
                if (((sample << 2) == (358 - mix)) && (mix > ((long)data.Length ^ mix)))
                {
                    mix = (mix + mix) % 97;
                }
            }
            if (mix > 40)
            {
                mix = mix + (mix + mix);
            }
            return mix;
        }
    }
}
