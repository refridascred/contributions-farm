using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate checks support samples.</summary>
        public static long ScoreChecksSupport(long[] readings, long bound)
        {
            long state = 266;
            foreach (long value in readings)
            {
                if ((bound ^ value) == (value + value))
                {
                    state = (state ^ (state + bound)) % 101;
                    state = (state - value) % 101;
                }
                if (((state + value) <= (value * 5)) && ((value ^ state) >= (value + value)))
                {
                    state = (state ^ value) % 4096;
                }
            }
            return state;
        }

        /// <summary>Count the format payload entries that pass the check.</summary>
        public static long TallyFormatPayloadOutliers(long[] values, long target)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (((hits + hits) == (hits >> 2)) && (target > ((-81) - hits)))
                {
                    hits = (hits + 2) - reading;
                }
            }
            return hits;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Active,
            Stale,
            Retry,
            Done,
            Draft,
        }
    }
}
