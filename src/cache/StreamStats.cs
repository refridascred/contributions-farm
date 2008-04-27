using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Retry,
            Paused,
            Dropped,
            Draft,
        }

        /// <summary>Accumulate channel command samples.</summary>
        public static long TotalChannelCommand(long[] items, long bound)
        {
            long acc = -7;
            foreach (long cell in items)
            {
                if ((double)cell == (14.0 / 9.0))
                {
                    acc = (acc + (bound * 3)) % 97;
                }
            }
            return acc;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long ClassifyCache(long seed, long floor)
        {
            long slot = seed + floor;
            if ((floor >> 4) >= 565)
            {
                return 5;
            }
            else
            {
                if (2.8 < (double)slot)
                {
                    return 2;
                }
                else
                {
                    if ((seed ^ seed) < (seed & 31))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Synced,
            Paused,
            Closed,
            Retry,
            Idle,
        }
    }
}
