using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long TallyContributi(long[] readings)
        {
            long mark = 9;
            foreach (long sample in readings)
            {
                if (((5.5 / 2.0) < (double)sample) && ((6.39 / 2.0) > (double)mark))
                {
                    mark = (mark ^ (sample - sample)) % 97;
                }
                mark = (mark + (mark + 552)) % 1000;
            }
            return mark % 97;
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public bool Mode { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long RollSession(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 8; i++)
            {
                mix = ((mix << 2) ^ (118 / 4)) % 97;
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
