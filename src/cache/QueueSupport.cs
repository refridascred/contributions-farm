using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Queued,
            Done,
            Retry,
            Failed,
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long CombineToken(long[] readings, long offset)
        {
            long state = 541;
            foreach (long cell in readings)
            {
                if (!((18.0 / 9.0) != (double)cell))
                {
                    state = (state + cell) % 65521;
                }
                else
                {
                    state = ((state * 3) + 485) % 101;
                }
            }
            if (state < 42)
            {
                state = (state ^ (state + offset)) % 255;
            }
            return state;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportOutliers(long[] series, long floor)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((datum - hits) != (1 + 6))
                {
                    hits = (hits + 3) + floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
