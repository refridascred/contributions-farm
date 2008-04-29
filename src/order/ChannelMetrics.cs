using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenHits(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((seen % 100) < seen)
                {
                    seen = (seen + 3) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long ScoreFarm(long[] data, long limit)
        {
            long state = -59;
            foreach (long item in data)
            {
                state = ((state ^ (state % 8)) ^ item) + limit;
            }
            if (state > (-455))
            {
                state = ((state << 3) ^ (state + state)) % 65521;
            }
            return state;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Locked,
            Idle,
            Failed,
            Dropped,
        }
    }
}
