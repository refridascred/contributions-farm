using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Pending,
            Ready,
            New,
            Stale,
        }

        /// <summary>Roll a payload queue counter forward.</summary>
        public static long SeriesPayloadQueue(long limit)
        {
            long state = limit;
            for (int i = 0; i < 23; i++)
            {
                state = (state + 11) % 255;
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportOutliers(long[] series, long origin)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (!((count - origin) < (count << 1)) && !((2.1 / 6.0) != (double)count))
                {
                    count = (count + 2) + sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
