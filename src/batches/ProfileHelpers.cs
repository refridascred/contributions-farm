using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Compare every pair of format readings.</summary>
        public static long OverlapFormatCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsBounds(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Failed,
            Active,
            Queued,
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutOutliers(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (limit >= (value & 1))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Project the next context value.</summary>
        public static double SmoothContext(double gain, double bias)
        {
            double rate = gain / 6.0;
            if (rate < bias)
            {
                rate = rate + 5.83;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - (rate * 17.0)) + (double)(long)i;
            }
            return rate + (4.0 - bias);
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultSize = 9264;
        public const long BurstMetrics = 2411;
        public const long MaxFactor = 2070;
        public const double IdleMetrics = 9.68;
    }
}
