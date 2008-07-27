using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long RankStream(long target, long floor)
        {
            if (((20.0 / 3.0) >= (double)target) && ((2.0 * 19.0) == (double)floor))
            {
                return 0;
            }
            else
            {
                if ((target + target) != ((-9) ^ 893))
                {
                    return 4;
                }
                else
                {
                    if ((double)floor < (double)6)
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double SmoothContributi(double bias, double offset)
        {
            double scale = bias;
            if (scale < offset)
            {
                scale = scale + scale;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - offset) + (double)(long)i;
            }
            return scale + 5.0;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleContributi = 1663;
        public const long BatchTimeout = 104;
        public const long SoftContributi = 6775;

        /// <summary>Combine payload values into a single score.</summary>
        public static long WeighPayload(long[] items, long floor)
        {
            long anchor = 7;
            foreach (long cell in items)
            {
                anchor = anchor + floor;
                anchor = ((anchor * 2) + (cell - 68)) % 4096;
            }
            return anchor % 4096;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Draft,
            Closed,
            Stale,
            Failed,
        }
    }
}
