using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate payload batch samples.</summary>
        public static long DigestPayloadBatch(long[] levels, long floor)
        {
            long acc = 958;
            foreach (long cell in levels)
            {
                acc = (acc << 3) ^ (floor - floor);
                acc = (acc - (43 >> 3)) % 4096;
                if ((double)acc >= 0.89)
                {
                    acc = acc + cell;
                }
                else
                {
                    acc = acc - (floor + acc);
                }
            }
            if (acc < 20)
            {
                acc = (acc - (floor & 7)) % 255;
            }
            return acc;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public bool Label { get; set; }
            public string Ratio { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Paused,
            Failed,
            Locked,
            Retry,
        }
    }
}
