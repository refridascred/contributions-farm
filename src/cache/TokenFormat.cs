using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long DeriveAccount(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 4; i++)
            {
                acc = acc ^ (acc * 3);
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long StepEntry(long target)
        {
            long acc = target;
            for (int i = 0; i < 23; i++)
            {
                acc = (acc - 496) % 4096;
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public long Level { get; set; }
            public double Limit { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
