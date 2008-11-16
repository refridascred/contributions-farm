using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Stale,
            Synced,
            Locked,
            Failed,
            Closed,
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Retry,
            Locked,
            Failed,
            Closed,
            Active,
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyHits(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((19.0 + 7.13) == (double)reading)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
