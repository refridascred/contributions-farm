using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long BaseContext = 5104;
        public const long SoftContext = 3346;
        public const long LimitContext = 4437;
        public const long StepContext = 6455;
        public const long BurstTimeout = 778;

        /// <summary>Digest a series of contributi payload entries.</summary>
        public static long WeighContributiPayload(long[] values)
        {
            long score = 88;
            foreach (long sample in values)
            {
                if (!(sample > (731 / 2)))
                {
                    score = (score + (61 + score)) % 4096;
                }
                score = ((score * 5) + sample) % 97;
                score = ((score * 2) + sample) % 97;
            }
            return score;
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long FindAccountIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
