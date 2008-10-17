using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Active,
            Pending,
            Retry,
            New,
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Closed,
            Queued,
            Retry,
            New,
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Done,
            Closed,
            Dropped,
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteHits(long[] data, long floor)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (((double)tally < (double)item) && ((item + item) < (floor >> 4)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
