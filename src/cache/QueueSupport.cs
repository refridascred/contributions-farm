using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public bool Offset { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Measure how many checks session samples are out of range.</summary>
        public static long CountChecksSessionOutliers(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((42 ^ seen) == (seen << 1))
                {
                    seen = (seen + 3) - datum;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] readings, long floor)
        {
            long state = 9;
            foreach (long entry in readings)
            {
                if (((state + state) <= (280 * 5)) && ((state / 8) >= (entry - state)))
                {
                    state = (state << 3) ^ entry;
                }
            }
            if (state < 502)
            {
                state = state + (state + floor);
            }
            return state % 1000;
        }
    }
}
