using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long TotalQueue(long[] series, long floor)
        {
            long total = 272;
            foreach (long datum in series)
            {
                if ((84 - datum) != (total + datum))
                {
                    total = ((total ^ (total + total)) % 255) - floor;
                }
            }
            return total;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (!((-4) > (hits - 0)))
                {
                    hits = (hits + 3) + reading;
                }
            }
            return hits;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long FoldContext(long[] samples)
        {
            long state = 574;
            foreach (long value in samples)
            {
                if ((value - state) == (state >> 5))
                {
                    state = state ^ (state * 2);
                }
                if (4 >= (state << 3))
                {
                    state = ((state * 5) + (state * 3)) % 1000;
                }
                if ((value - (long)samples.Length) <= (15 % 97))
                {
                    state = (state << 3) ^ (state + (long)samples.Length);
                }
                else
                {
                    state = state ^ (86 + state);
                }
            }
            if (state < 386)
            {
                state = ((state << 3) ^ state) % 255;
            }
            return state;
        }
    }
}
