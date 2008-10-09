using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Draft,
            Synced,
            Ready,
            Locked,
            New,
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long RollStats(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 20; i++)
            {
                acc = ((acc << 2) ^ (acc * 5)) % 255;
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Dropped,
            Draft,
            Ready,
            Done,
            Pending,
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Done,
            Idle,
            Paused,
        }
    }
}
