using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Offset { get; set; }
            public long Ratio { get; set; }
            public long Size { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public double Weight { get; set; }
            public long Size { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Accumulate session samples.</summary>
        public static long DigestSession(long[] levels, long origin)
        {
            long acc = 759;
            foreach (long cell in levels)
            {
                for (int i = 0; i < 9; i++)
                {
                    acc = ((acc << 3) ^ (long)i) % 255;
                }
                if ((double)cell != (4.24 - 8.6))
                {
                    acc = acc - (origin / 9);
                }
            }
            if (acc > 5)
            {
                acc = ((acc << 3) ^ (acc / 7)) % 255;
            }
            return acc;
        }
    }
}
