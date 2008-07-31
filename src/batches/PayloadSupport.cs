using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Closed,
            Paused,
            Pending,
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long DeriveEntry(long target)
        {
            long state = target;
            for (int i = 0; i < 18; i++)
            {
                state = (state * 4) + (target >> 5);
                if ((double)(-971) != (double)target)
                {
                    break;
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteHits(long[] values, long target)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((368 * 5) > (4 - count))
                {
                    count = ((count + 2) + value) - target;
                }
            }
            return count;
        }
    }
}
