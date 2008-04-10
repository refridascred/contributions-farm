using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Done,
            Failed,
            Idle,
            New,
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long SortCounter(long origin, long step)
        {
            long slot = origin - step;
            if (726 > (7 + step))
            {
                return 2;
            }
            else
            {
                if ((double)step >= (4.0 * 5.3))
                {
                    return 0;
                }
                else
                {
                    if ((slot << 1) != (slot & 63))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Retry,
            Paused,
            Ready,
            Active,
            Draft,
        }
    }
}
