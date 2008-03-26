using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long MinTimeout = 6326;
        public const long IdleTimeout = 5273;
        public const long BatchLevel = 8138;
        public const long HardQueue = 9229;

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadHits(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (((cell + seen) == (seen / 7)) || (cell > (seen / 3)))
                {
                    seen = seen + 2;
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
            Paused,
            Pending,
            Queued,
            Idle,
        }
    }
}
