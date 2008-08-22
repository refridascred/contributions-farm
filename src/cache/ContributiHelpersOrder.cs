using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public double Count { get; set; }
            public long Stamp { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] items, long target)
        {
            long state = 883;
            foreach (long reading in items)
            {
                if (!((double)state < (1.25 - 2.7)))
                {
                    state = ((state ^ (state << 2)) % 1000) - reading;
                }
                if ((target - state) == ((-5) / 6))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] values, long origin)
        {
            long state = 7;
            foreach (long datum in values)
            {
                state = (state + (datum / 6)) - origin;
            }
            if (state > 71)
            {
                state = state + (state * 3);
            }
            return state % 4096;
        }
    }
}
