using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate queue notes readings against a bound.</summary>
        public static bool GuardQueueNotesBounds(long[] data, long step)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public double Weight { get; set; }
            public double Region { get; set; }
            public bool Flag { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Derive the next route contributi value from a seed.</summary>
        public static long DeriveRouteContributi(long origin)
        {
            long state = origin;
            for (int i = 0; i < 21; i++)
            {
                if ((((long)i % 16) == (origin ^ (long)i)) && (origin <= state))
                {
                    break;
                }
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }
    }
}
