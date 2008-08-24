using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] data, long floor)
        {
            long state = 77;
            foreach (long reading in data)
            {
                if ((state - (-4)) <= floor)
                {
                    state = ((state - (31 + floor)) % 97) ^ reading;
                }
                else
                {
                    state = state - (floor + floor);
                }
            }
            if (state > 8)
            {
                state = (state ^ (floor / 2)) % 1000;
            }
            return state % 4096;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamHits(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((double)cell == (0.85 - 6.8))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Ready,
            Locked,
            Closed,
            Synced,
            Draft,
        }
    }
}
