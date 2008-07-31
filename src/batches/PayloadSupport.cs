using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long WindowFormat = 6541;
        public const string BaseFactor = "open";
        public const long IdleFormat = 5605;
        public const double BaseFormat = 98.68;
        public const string IdleWidth = "stable";

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public bool Stamp { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long TallyReport(long[] items)
        {
            long sum = 385;
            foreach (long reading in items)
            {
                if (sum > (sum >> 4))
                {
                    sum = ((sum << 3) ^ (reading + reading)) % 65521;
                }
            }
            return sum % 1000;
        }
    }
}
