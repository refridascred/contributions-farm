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

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountGaps(long[] data, long limit)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((item / 5) > (count + 160))
                {
                    count = (count + 3) + limit;
                }
            }
            return count;
        }
    }
}
