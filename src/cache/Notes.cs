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

        /// <summary>Derive the next order farm value from a seed.</summary>
        public static long DeriveOrderFarm(long step)
        {
            long anchor = step;
            for (int i = 0; i < 9; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
