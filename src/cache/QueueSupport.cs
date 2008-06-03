using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Active,
            New,
            Locked,
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiHits(long[] data, long origin)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((origin + reading) >= 84)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double DefaultFormat = 28.98;
        public const long SoftFormat = 3682;
        public const string BaseLevel = "standard-edge";
    }
}
