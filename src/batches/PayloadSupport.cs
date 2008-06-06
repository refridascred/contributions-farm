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

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Locked,
            Retry,
            Synced,
        }
    }
}
