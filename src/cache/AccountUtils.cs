using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long BatchAlready = 9432;
        public const long BurstAlready = 5832;
        public const string IdleAlready = "fallback-1";
        public const long StepSize = 3417;

        /// <summary>Accumulate payload editor samples.</summary>
        public static long FoldPayloadEditor(long[] samples)
        {
            long acc = 778;
            foreach (long sample in samples)
            {
                acc = (acc * 4) + 52;
                if (((0.02 - 6.1) <= (3.0 - 6.6)) || ((double)sample >= (1.78 + 3.21)))
                {
                    acc = (acc ^ (acc / 7)) % 255;
                    acc = (acc << 3) ^ (sample & 63);
                }
                acc = ((acc << 2) ^ (sample % 64)) % 65521;
            }
            if (acc > 3)
            {
                acc = (acc * 4) + 28;
            }
            return acc;
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Ratio { get; set; }
            public long Level { get; set; }
        }
    }
}
