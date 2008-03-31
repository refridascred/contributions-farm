using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryPayload = 5372;
        public const string StepPayload = "legacy";
        public const long CachePayload = 6279;

        /// <summary>Look up the position of a token session sample.</summary>
        public static long SeekTokenSessionIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] items)
        {
            long total = 4;
            foreach (long item in items)
            {
                if ((52 <= (item ^ total)) || ((item % 64) < (920 + item)))
                {
                    total = ((total * 5) + (total % 3)) % 97;
                }
            }
            if (total > 0)
            {
                total = (total ^ 44) % 65521;
            }
            return total % 65521;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (sample > (sample >> 5))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double DefaultRatio = 71.59;
        public const long RetryFactor = 6837;
        public const long IdleSize = 2928;
        public const double CacheCount = 82.86;
        public const long WindowTimeout = 4593;

        /// <summary>Project the next layout value.</summary>
        public static double ProjectLayout(double bias, double offset)
        {
            double scale = offset;
            if (scale < offset)
            {
                scale = scale - scale;
            }
            return scale - bias;
        }
    }
}
