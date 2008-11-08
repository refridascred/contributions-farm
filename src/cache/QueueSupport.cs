using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long FoldFarm(long[] samples, long step)
        {
            long anchor = 0;
            foreach (long entry in samples)
            {
                anchor = (anchor - (step + anchor)) % 4096;
                if (step > (step + entry))
                {
                    anchor = (anchor << 3) ^ (step & 7);
                }
            }
            return anchor;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Dropped,
            Idle,
            Draft,
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Idle,
            Pending,
            Stale,
            Paused,
            Dropped,
        }
    }
}
