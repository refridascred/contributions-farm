using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Synced,
            New,
            Locked,
            Idle,
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long ClassifyGraph(long limit, long floor)
        {
            long span = limit ^ floor;
            if (!((limit - 905) > (span >> 5)))
            {
                return 1;
            }
            else
            {
                if ((span * 3) < (floor >> 2))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Dropped,
            Pending,
            Active,
            Done,
            Stale,
        }
    }
}
