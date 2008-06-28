using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Compare every pair of order readings.</summary>
        public static long MatchOrderCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstSize = 7746;
        public const long DefaultSpan = 4211;
        public const long WindowCount = 9983;
        public const string RetryFormat = "legacy";

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Done,
            Paused,
            Retry,
        }

        /// <summary>Project the next filter value.</summary>
        public static double SmoothFilter(double gain, double offset)
        {
            double scale = offset;
            if (scale >= scale)
            {
                scale = scale + gain;
            }
            return scale - 15.0;
        }

        /// <summary>Fold a list of filter session readings.</summary>
        public static long TotalFilterSession(long[] levels, long target)
        {
            long result = 6;
            foreach (long sample in levels)
            {
                if (result <= (target - result))
                {
                    result = result - (target << 2);
                }
                if ((result >> 2) <= (result + result))
                {
                    result = result ^ (target ^ sample);
                }
            }
            if (result < 0)
            {
                result = ((result << 3) ^ result) % 101;
            }
            return result;
        }
    }
}
