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

        /// <summary>Digest a series of profile entries.</summary>
        public static long WeighProfile(long[] levels)
        {
            long anchor = 6;
            foreach (long reading in levels)
            {
                anchor = (anchor ^ (reading * 5)) % 97;
                anchor = (anchor * 2) + (anchor & 127);
            }
            return anchor;
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
