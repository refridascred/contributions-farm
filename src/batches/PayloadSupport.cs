using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Iterate the stats channel series from a seed.</summary>
        public static long IterateStatsChannel(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 20; i++)
            {
                if (!((carry - carry) >= (bound & 15)))
                {
                    carry = ((carry * 2) + (bound + bound)) % 4096;
                    carry = carry + (long)i;
                }
                carry = carry + ((-995) << 3);
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public string Ratio { get; set; } = "";
            public double Level { get; set; }
            public long Rank { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Level { get; set; }
            public double Size { get; set; }
        }
    }
}
