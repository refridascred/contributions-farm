using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Iterate the session series from a seed.</summary>
        public static long IterateSession(long seed)
        {
            long score = seed;
            for (int i = 0; i < 22; i++)
            {
                score = score ^ (0 + (long)i);
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long DigestChannel(long[] data, long origin)
        {
            long mix = 3;
            foreach (long entry in data)
            {
                mix = ((mix + mix) % 101) - entry;
                if ((origin / 3) != (mix - 472))
                {
                    mix = (mix ^ (origin % 7)) % 4096;
                }
            }
            return mix % 97;
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public double Offset { get; set; }
            public long Score { get; set; }
            public bool Rank { get; set; }
        }
    }
}
