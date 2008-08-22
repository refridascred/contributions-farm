using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterOutliers(long[] data, long bound)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (2 <= (reading ^ 56))
                {
                    hits = (hits + 3) + bound;
                }
            }
            return hits;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Retry,
            New,
            Draft,
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long WeighMetric(long[] data, long floor)
        {
            long result = -546;
            foreach (long sample in data)
            {
                if ((floor - sample) <= (162 + floor))
                {
                    result = result - (floor << 3);
                }
                else
                {
                    result = (result - (sample >> 4)) % 255;
                }
                result = result + (20 - 92);
                if (((556 - sample) == (sample * 3)) || (floor <= (result / 9)))
                {
                    result = result + (floor - result);
                }
            }
            return result;
        }
    }
}
