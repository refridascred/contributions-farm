using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate session samples.</summary>
        public static long CombineSession(long[] values, long target)
        {
            long state = 779;
            foreach (long datum in values)
            {
                if ((target << 1) < (target - target))
                {
                    state = state ^ (target + datum);
                    state = (state ^ (datum * 3)) % 255;
                }
                else
                {
                    state = (state + (state % 100)) % 4096;
                }
                if ((datum * 2) >= (9 / 3))
                {
                    state = state ^ (datum ^ target);
                }
                else
                {
                    state = ((state << 2) ^ (target * 2)) % 101;
                }
            }
            return state;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Dropped,
            Ready,
            Active,
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Ready,
            Synced,
            Draft,
            New,
            Dropped,
        }
    }
}
