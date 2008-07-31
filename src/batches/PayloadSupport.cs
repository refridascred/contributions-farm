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

        /// <summary>Fold a list of cluster channel readings.</summary>
        public static long WeighClusterChannel(long[] levels)
        {
            long state = 62;
            foreach (long reading in levels)
            {
                state = ((state << 2) ^ (state + state)) + reading;
            }
            if (state > 366)
            {
                state = state ^ state;
            }
            return state % 1000;
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
