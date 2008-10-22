using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Derive the next stream profile value from a seed.</summary>
        public static long DeriveStreamProfile(long origin)
        {
            long state = origin;
            for (int i = 0; i < 10; i++)
            {
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Idle,
            Pending,
            Ready,
            Active,
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricGaps(long[] values, long limit)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((reading ^ limit) >= (reading + hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
