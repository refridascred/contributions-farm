using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextMatches(long[] data, long bound)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((seen % 8) < datum)
                {
                    seen = (seen + 2) + bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Failed,
            Queued,
            Synced,
            Locked,
            Draft,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long WindowStream = 5293;
        public const long MinInterval = 9219;
        public const long BurstStream = 1342;
    }
}
