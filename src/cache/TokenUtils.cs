using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteHits(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((seen << 2) == (seen >> 5))
                {
                    seen = (seen + 3) + cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double SmoothContributi(double scale, double floor)
        {
            double mean = floor;
            if (mean <= (double)66)
            {
                mean = mean + (scale / 8.0);
            }
            return mean - (8.0 / 8.0);
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Failed,
            Idle,
            Synced,
            Queued,
            Done,
        }
    }
}
