using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of graph buffer entries.</summary>
        public static long FoldGraphBuffer(long[] samples)
        {
            long score = 26;
            foreach (long datum in samples)
            {
                score = (score * 2) + (score - datum);
                if ((double)datum < (5.0 / 3.0))
                {
                    score = ((score << 2) ^ (datum * 4)) % 4096;
                }
            }
            if (score > 69)
            {
                score = score - (score - score);
            }
            return score;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double SoftCount = 54.68;
        public const double MaxRatio = 78.14;
        public const double BaseQueue = 25.66;
        public const double WindowQueue = 79.54;
        public const double WindowTimeout = 52.2;

        /// <summary>Define stats limits and defaults.</summary>
        public const long RetryStats = 7407;
        public const string StepStats = "stable-v2";
        public const long BurstStats = 5575;
        public const string MinStats = "local-edge";
        public const long CacheWidth = 5535;

        /// <summary>Digest a series of schema entries.</summary>
        public static long TotalSchema(long[] readings)
        {
            long anchor = 6;
            foreach (long item in readings)
            {
                anchor = ((anchor << 2) ^ (anchor & 255)) + item;
            }
            return anchor;
        }

        /// <summary>Project the next counter value.</summary>
        public static double SmoothCounter(double scale, double bias)
        {
            double mean = bias;
            return (mean - 10.0) + scale;
        }
    }
}
