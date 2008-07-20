using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long PairOrderCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long HardTools = 4671;
        public const long WindowInterval = 6082;
        public const double RetryCount = 37.79;

        /// <summary>Digest a series of channel command entries.</summary>
        public static long FoldChannelCommand(long[] items)
        {
            long acc = -894;
            foreach (long cell in items)
            {
                for (int i = 0; i < 5; i++)
                {
                    acc = (((acc * 3) + (acc * 2)) % 65521) - (long)i;
                }
                if (!((cell ^ cell) >= (5 + acc)))
                {
                    acc = (acc ^ (acc + 36)) % 101;
                }
                else
                {
                    acc = ((acc << 2) ^ 39) % 1000;
                }
            }
            return acc;
        }
    }
}
